# A simple mvc extension for DataTables.js

# Useage
1.  ` @Html.DataTables("example") `
2.  ` @Html.DataTables("example").DataTable(d => d.LengthMenu(10, 20, 50, "All")) `
3.  ` @Html.DataTables("table2")  
            .DataTable(d => d.Ordering(false).Data(@<text>dataSet</text>) )    
            .Columns(col=> {     
                    col.Add("Name").Title("Name");
                    col.Add("Position").Title("Position");
                    col.Add("Office").Title("Office");
                    col.Add("Extn.").Title("Extn");
                    col.Add("Start date").Title("Start date");
                    col.Add("Salary").Title("Salary");
                })
            .ColumnDefs(col=> {
                    col.TargetAll().ClassName("fdsfds").Render(@<text> function(data, type, row){ return data; } </text>);
                }) `