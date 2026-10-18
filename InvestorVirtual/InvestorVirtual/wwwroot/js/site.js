// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

document.addEventListener("DOMContentLoaded", function () {
    const rootElement = document.documentElement;
    const themeSwatches = document.querySelectorAll(".theme-swatch-btn");
    const modeButtons = document.querySelectorAll(".mode-toggle-btn");

    // 1. Initialize active states on footer swatches based on what's already on <html>
    const currentTheme = Array.from(rootElement.classList).find(c => c.startsWith("theme-")) || "theme-vaulted-gold";
    updateActiveSwatch(currentTheme);

    // 2. Initialize saved mode
    const savedMode = localStorage.getItem("terminal-mode") || "dark";
    applyMode(savedMode);

    // 3. Theme Swatch Click Handler
    themeSwatches.forEach(swatch => {
        swatch.addEventListener("click", function () {
            const selectedTheme = this.getAttribute("data-theme");
            applyTheme(selectedTheme);
            localStorage.setItem("terminal-theme", selectedTheme);
        });
    });

    // 4. Light/Dark Mode Toggle Handler
    modeButtons.forEach(btn => {
        btn.addEventListener("click", function () {
            const selectedMode = this.getAttribute("data-mode");
            applyMode(selectedMode);
            localStorage.setItem("terminal-mode", selectedMode);
        });
    });

    function applyTheme(themeClass) {
        rootElement.classList.remove(
            "theme-vaulted-gold",
            "theme-cyber-dusk",
            "theme-crimson-emerald",
            "theme-sky-mint"
        );
        rootElement.classList.add(themeClass);
        updateActiveSwatch(themeClass);
    }

    function updateActiveSwatch(themeClass) {
        themeSwatches.forEach(swatch => {
            if (swatch.getAttribute("data-theme") === themeClass) {
                swatch.classList.add("active");
            } else {
                swatch.classList.remove("active");
            }
        });
    }

    function applyMode(mode) {
        if (mode === "light") {
            rootElement.classList.add("light-mode");
        } else {
            rootElement.classList.remove("light-mode");
        }

        modeButtons.forEach(btn => {
            if (btn.getAttribute("data-mode") === mode) {
                btn.classList.add("active");
            } else {
                btn.classList.remove("active");
            }
        });
    }
});