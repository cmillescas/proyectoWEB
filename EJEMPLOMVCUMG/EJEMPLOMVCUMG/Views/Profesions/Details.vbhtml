@ModelType EJEMPLOMVCUMG.Profesion
@Code
    ViewData("Title") = "Details"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<h2>Details</h2>

<div>
    <h4>Profesion</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.nombreProfesion)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.nombreProfesion)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.idProfesion }) |
    @Html.ActionLink("Back to List", "Index")
</p>
