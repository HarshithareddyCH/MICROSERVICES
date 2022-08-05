﻿@Model WebApplication3.Models.Employee

@{
    ViewData["Title"] = "Create";
}

<h1>Create</h1>

<h4>Employee</h4>
<hr />
<div class="row">
    <div class="col-md-4">
        <form asp-action="Create">
            <div asp-validation-summary="ModelOnly" class="text-danger"></div>

            <div class="form-group">
                <label asp-for="EmployeeName" class="control-label"></label>
                <input asp-for="EmployeeName" class="form-control" />
                <span asp-validation-for="EmployeeName" class="text-danger"></span>
            </div>
            <div class="form-group">
                <label asp-for="EmployeeJob" class="control-label"></label>
                <input asp-for="EmployeeJob" class="form-control" />
                <span asp-validation-for="EmployeeJob" class="text-danger"></span>
            </div>
            <div class="form-group">
                <label asp-for="EmployeeSalary" class="control-label"></label>
                <input asp-for="EmployeeSalary" class="form-control" />
                <span asp-validation-for="EmployeeSalary" class="text-danger"></span>
            </div>
            <div class="form-group">
                <input type="submit" value="Create" class="btn btn-primary" />
            </div>
        </form>
    </div>
</div>

<div>
    <a asp-action="Index">Back to List</a>
</div>

@section Scripts {
    @{await Html.RenderPartialAsync("_ValidationScriptsPartial");}
    }