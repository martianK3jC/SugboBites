document.addEventListener("click", (event) => {
    if (!(event.target instanceof Element)) return;

    if (event.target.closest(".skip-link")) {
        event.preventDefault();
        const content = document.getElementById("main-content");
        content?.focus();
        content?.scrollIntoView({ block: "start" });
    }

    if (event.target.closest("#blazor-error-ui .dismiss")) {
        const notice = document.getElementById("blazor-error-ui");
        if (notice) notice.style.display = "none";
    }
});
