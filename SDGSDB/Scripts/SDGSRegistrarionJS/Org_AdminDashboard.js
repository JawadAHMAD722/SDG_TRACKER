$(document).ready(function () {
	var apiBaseUrl = document.getElementById('ApiBaseURL').innerHTML;
	//var apiBaseUrl = '<%= System.Configuration.ConfigurationManager.AppSettings.Get("ApiBaseUrl") %>';
var UID = document.getElementById('lblDashboardUserID').innerHTML;
$.ajax({
    type: 'Get',
    url: apiBaseUrl+'/GetRegistrNGO?UserID=' + UID,
    dataType: 'json',
    success: function (result) {

        var JSONDATA = JSON.parse(result);
        //alert(JSONDATA);
        $.each(JSONDATA, function (index, val) {
            var Organization_Type = parseInt(val.Organization_Type_Id);
            document.getElementById('lblOrg').innerText = val.Organization_Name;
            document.getElementById('lblOrg2').innerText = val.Organization_Name;
            document.getElementById('lblOrgProfiler').innerText = val.Organization_Name;
            document.getElementById('LogoImg').src = apiBaseUrl+'/NGOLogos/' + val.Logo_Image;
            document.getElementById('LogoImg2').src = apiBaseUrl+'/NGOLogos/' + val.Logo_Image;
            document.getElementById('LogoImgProfiler').src = apiBaseUrl+'/NGOLogos/' + val.Logo_Image;
            
        });
    }
});

});