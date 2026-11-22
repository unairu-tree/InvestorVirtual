(function () {
    const newsModalEl = document.getElementById("newsDetailModal");
    if (!newsModalEl) return;

    const eventTitleEl = document.getElementById("newsModalEventTitle");
    const eventDateEl = document.getElementById("newsModalDate");
    const headlineEl = document.getElementById("newsModalHeadline");
    const sourceEl = document.getElementById("newsModalSource");
    const bodyEl = document.getElementById("newsModalBody");

    document.querySelectorAll(".news-event-card").forEach(function (card) {
        card.addEventListener("click", function () {
            const eventTitle = card.getAttribute("data-event-title") || "";
            const eventDate = card.getAttribute("data-event-date") || "";
            const newsTitle = card.getAttribute("data-news-title") || eventTitle || "Market Update";
            const newsSource = card.getAttribute("data-news-source") || "Market Wire";
            const newsBody = card.getAttribute("data-news-body") || "No news commentary recorded for this timeline event.";

            if (eventTitleEl) eventTitleEl.textContent = eventTitle;
            if (eventDateEl) eventDateEl.textContent = eventDate;
            if (headlineEl) headlineEl.textContent = newsTitle;
            if (sourceEl) sourceEl.textContent = newsSource;
            if (bodyEl) bodyEl.textContent = newsBody;
        });
    });
})();