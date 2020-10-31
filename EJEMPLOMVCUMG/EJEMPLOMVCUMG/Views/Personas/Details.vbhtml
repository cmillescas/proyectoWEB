@ModelType EJEMPLOMVCUMG.Personas
@Code
    ViewData("Title") = "Details"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<h2>Details</h2>

<div>
    <h4>Personas</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.primerNombre)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.primerNombre)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.segundoNombre)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.segundoNombre)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.apellidos)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.apellidos)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.direccion)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.direccion)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.telefono)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.telefono)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Profesion.nombreProfesion)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Profesion.nombreProfesion)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.idPersona }) |
    @Html.ActionLink("Back to List", "Index")
</p>
