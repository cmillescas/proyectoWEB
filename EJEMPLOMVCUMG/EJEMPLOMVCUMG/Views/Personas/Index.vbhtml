@ModelType IEnumerable(Of EJEMPLOMVCUMG.Personas)
@Code
ViewData("Title") = "Index"
Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<h2>Index</h2>

<p>
    @Html.ActionLink("Create New", "Create")
</p>
<table class="table">
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.primerNombre)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.segundoNombre)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.apellidos)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.direccion)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.telefono)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Profesion.nombreProfesion)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.primerNombre)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.segundoNombre)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.apellidos)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.direccion)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.telefono)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Profesion.nombreProfesion)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.idPersona }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.idPersona }) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.idPersona })
        </td>
    </tr>
Next

</table>
