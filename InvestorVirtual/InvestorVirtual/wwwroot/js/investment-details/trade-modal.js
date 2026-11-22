(function () {
    function wireTradeModal(config) {
        const modalEl = document.getElementById(config.modalId);
        const formEl = document.getElementById(config.formId);
        const swapBtn = document.getElementById(config.swapBtnId);
        const primaryLabel = document.getElementById(config.primaryLabelId);
        const primaryPrefix = document.getElementById(config.primaryPrefixId);
        const primaryInput = document.getElementById(config.primaryInputId);
        const secondaryLabel = document.getElementById(config.secondaryLabelId);
        const secondaryValue = document.getElementById(config.secondaryValueId);
        const priceEl = document.getElementById(config.priceId);
        const computedSharesInput = document.getElementById(config.computedSharesId);
        const computedTotalInput = document.getElementById(config.computedTotalId);
        const noticeEl = document.getElementById(config.noticeId);

        if (!modalEl || !formEl || !primaryInput || !secondaryValue || !priceEl) return;

        const unitPrice = parseFloat(priceEl.getAttribute("data-unit-price") || "0") || 0;
        let mode = "shares"; // "shares" | "amount"

        function applyModeUi() {
            if (noticeEl) noticeEl.classList.add("d-none");

            if (mode === "shares") {
                formEl.setAttribute("data-trade-mode", "shares");
                if (primaryLabel) primaryLabel.textContent = config.sharesLabel;
                if (primaryPrefix) primaryPrefix.classList.add("d-none");

                primaryInput.step = "0.0001";
                primaryInput.min = "0.0001";
                primaryInput.placeholder = "0.0000";
                primaryInput.value = "1";

                if (secondaryLabel) secondaryLabel.textContent = config.totalLabel;
                secondaryValue.className = "fw-bold " + config.accentClass + " fs-5";
            } else {
                formEl.setAttribute("data-trade-mode", "amount");
                if (primaryLabel) primaryLabel.textContent = config.amountLabel;
                if (primaryPrefix) primaryPrefix.classList.remove("d-none");

                primaryInput.step = "0.01";
                primaryInput.min = "0.01";
                primaryInput.placeholder = "0.00";
                primaryInput.value = unitPrice > 0 ? unitPrice.toFixed(2) : "100.00";

                if (secondaryLabel) secondaryLabel.textContent = "Estimated Shares";
                secondaryValue.className = "fw-bold " + config.accentClass + " fs-5";
            }

            recalculate();
        }

        function recalculate() {
            const rawVal = parseFloat(primaryInput.value);
            const cleanVal = Number.isFinite(rawVal) && rawVal > 0 ? rawVal : 0;

            if (mode === "shares") {
                const shares = cleanVal;
                const total = unitPrice > 0 ? shares * unitPrice : 0;

                secondaryValue.textContent = "$" + total.toFixed(2);
                if (computedSharesInput) computedSharesInput.value = shares.toFixed(4);
                if (computedTotalInput) computedTotalInput.value = total.toFixed(2);
            } else {
                const amount = cleanVal;
                const shares = unitPrice > 0 ? amount / unitPrice : 0;

                secondaryValue.textContent = shares.toLocaleString(undefined, {
                    minimumFractionDigits: 2,
                    maximumFractionDigits: 4
                }) + " shares";

                if (computedSharesInput) computedSharesInput.value = shares.toFixed(4);
                if (computedTotalInput) computedTotalInput.value = amount.toFixed(2);
            }
        }

        if (swapBtn) {
            swapBtn.addEventListener("click", function () {
                mode = mode === "shares" ? "amount" : "shares";
                applyModeUi();
                primaryInput.focus();
                primaryInput.select();
            });
        }

        modalEl.addEventListener("show.bs.modal", function () {
            mode = "shares";
            applyModeUi();
        });

        primaryInput.addEventListener("input", recalculate);

        formEl.addEventListener("submit", function (e) {
            e.preventDefault();
            recalculate();
            if (noticeEl) {
                noticeEl.classList.remove("d-none");
            }
        });
    }

    wireTradeModal({
        modalId: "buyModal",
        formId: "buyOrderForm",
        swapBtnId: "buySwapModeBtn",
        primaryLabelId: "buyPrimaryLabel",
        primaryPrefixId: "buyPrimaryPrefix",
        primaryInputId: "buyPrimaryInput",
        secondaryLabelId: "buySecondaryLabel",
        secondaryValueId: "buySecondaryValue",
        priceId: "buyModalPrice",
        computedSharesId: "buyComputedShares",
        computedTotalId: "buyComputedTotal",
        noticeId: "buyFrontendNotice",
        sharesLabel: "Shares to Buy",
        amountLabel: "Amount to Spend",
        totalLabel: "Estimated Total",
        accentClass: "text-success"
    });

    wireTradeModal({
        modalId: "sellModal",
        formId: "sellOrderForm",
        swapBtnId: "sellSwapModeBtn",
        primaryLabelId: "sellPrimaryLabel",
        primaryPrefixId: "sellPrimaryPrefix",
        primaryInputId: "sellPrimaryInput",
        secondaryLabelId: "sellSecondaryLabel",
        secondaryValueId: "sellSecondaryValue",
        priceId: "sellModalPrice",
        computedSharesId: "sellComputedShares",
        computedTotalId: "sellComputedTotal",
        noticeId: "sellFrontendNotice",
        sharesLabel: "Shares to Sell",
        amountLabel: "Target Proceeds Amount",
        totalLabel: "Estimated Proceeds",
        accentClass: "text-danger"
    });
})();