$(document).ready(function () {
	var apiBaseUrl = document.getElementById('ApiBaseURL').innerHTML;
	//var apiBaseUrl = '<%= System.Configuration.ConfigurationManager.AppSettings.Get("ApiBaseUrl") %>';
    var content = "@ViewBag.id";
    alert(content)
    var Organization_Id = 1010
    $.ajax({
        type: 'Get',
        url: apiBaseUrl+'/GetRegistrOrgEmail?Organization_Id=' + Organization_Id,
        dataType: 'json',
        success: function (result) {
            //alert(result);
            var JSONDATA = JSON.parse(result);
            //alert(JSONDATA);
            $.each(JSONDATA, function (index, val) {
                $("#Email").val(val.Person_Contact_Email);
            });
        }
    });


});