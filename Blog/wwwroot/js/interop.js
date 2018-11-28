window.initHighlight = () => {
    for (const element of document.getElementsByTagName("pre")) {
        hljs.highlightBlock(element);
    }
};
