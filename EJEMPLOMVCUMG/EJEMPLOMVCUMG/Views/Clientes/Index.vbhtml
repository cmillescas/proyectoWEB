
@Code
    ViewData("Title") = "Index"
End Code

<h2>Index</h2>

<p>
    @Html.ActionLink("Create New", "Create")
</p>
<table class="table">
    <tr>
        <th>
            "ID"
        </th>
        <th>
            "CLIENTE"
        </th>
        <th></th>
    </tr>


    <tr>
        <td>
            "0"
        </td>
        <td>
            "LUIS"
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", 3) |
            @Html.ActionLink("Details", "Details", 2) |
            @Html.ActionLink("Delete", "Delete", 1)
        </td>
    </tr>


</table>
