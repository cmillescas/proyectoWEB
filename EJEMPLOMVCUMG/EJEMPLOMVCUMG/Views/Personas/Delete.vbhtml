@ModelType EJEMPLOMVCUMG.Personas
@Code
    ViewData("Title") = "Delete"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<h2>Delete</h2>

<h3>Are you sure you want to delete this?</h3>
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
    @Using (Html.BeginForm())
        @Html.AntiForgeryToken()

        @<div class="form-actions no-color">
            <input type="submit" value="Delete" class="btn btn-default" /> |
            @Html.ActionLink("Back to List", "Index")
        </div>
    End Using
</div>
