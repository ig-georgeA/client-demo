const html = window.igTemplating.html;
igRegisterScript("columnBodyTemplateScript", (ctx) => {
    return html`
        <div grid-with-templates-scope class="row-layout group_1">
            <igc-avatar src="${ctx.cell.row.data.AvatarUrl}" shape="rounded" grid-with-templates-scope class="avatar"></igc-avatar>
            <p grid-with-templates-scope class="typography__body-2 text">
                ${ctx.cell.row.data.FirstName}
            </p>
            <p grid-with-templates-scope class="typography__body-2 text">
                ${ctx.cell.value}
            </p>
        </div>
    `
}, false);
igRegisterScript("columnBodyTemplateScript1", (ctx) => {
    return html`
    `
}, false);
igRegisterScript("columnBodyTemplateScript2", (ctx) => {
    return html`
        <igc-chip grid-with-templates-scope class="chip">
            <span grid-with-templates-scope slot="prefix">
                <span grid-with-templates-scope class="material-icons icon">
                    phone
                </span>
            </span>
            ${ctx.cell.value}
        </igc-chip>
    `
}, false);
igRegisterScript("columnBodyTemplateScript3", (ctx) => {
    return html`
        <igc-button variant="flat" grid-with-templates-scope class="button">
            <span grid-with-templates-scope>View details</span>
            <span grid-with-templates-scope class="material-icons">
                arrow_forward
            </span>
            <igc-ripple></igc-ripple>
        </igc-button>
    `
}, false);
