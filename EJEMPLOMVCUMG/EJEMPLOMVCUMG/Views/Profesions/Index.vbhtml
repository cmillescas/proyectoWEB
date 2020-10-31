@ModelType IEnumerable(Of EJEMPLOMVCUMG.Profesion)
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
            @Html.DisplayNameFor(Function(model) model.nombreProfesion)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.nombreProfesion)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.idProfesion }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.idProfesion }) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.idProfesion })
        </td>
    </tr>
Next

</table>
