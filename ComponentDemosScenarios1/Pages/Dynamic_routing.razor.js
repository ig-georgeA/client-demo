const html = window.igTemplating.html;
igRegisterScript("columnBodyTemplateScript", (ctx) => {
    return html`
        <a dynamic-routing-scope @click="${() => window.dotNetHelper.invokeMethodAsync('Navigate', `/route_details/${ctx.cell.value}`)}" class="typography__body-2 hyperlink">
            ${ctx.cell.value}
        </a>
    `
}, false);

window.setDotNetRef = (dotNetHelper) => {
    window.dotNetHelper = dotNetHelper;
}
