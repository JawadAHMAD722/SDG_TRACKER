$(document).ready(function () {
	var apiBaseUrl = document.getElementById('ApiBaseURL').innerHTML;
	//var apiBaseUrl = '<%= System.Configuration.ConfigurationManager.AppSettings.Get("ApiBaseUrl") %>'
    var UserID = document.getElementById('lblGUID').innerHTML;
   
    //Get Registered NGO
    $.ajax({
        type: 'Get',
        url: apiBaseUrl+'/GetLoginNGOOfficeInfo?UserID=' + UserID,
        dataType: 'json',
        success: function (result) {
            //var OrgID = document.getElementById('lblLoginNGO').innerText;
            //alert(result);
            var JSONDATA = JSON.parse(result);
            //alert(JSONDATA);
            $.each(JSONDATA, function (index, val) {
                //alert(val.Logo_Image);
                document.getElementById('lblLoginNGO').innerText = val.Organization_Name;
                document.getElementById('lblLoginNGO1').innerText = val.Organization_Name;
                document.getElementById('lblLogiNGO2').innerText = val.Organization_Name;
                document.getElementById('lblLoginOffice2').innerText = val.Office_Name;
                document.getElementById('lblLoginNGOOffice').innerText = val.Office_Name;
                if (val.Logo_Image == null || val.Logo_Image == "") {
                    //alert("Equal");
                    //alert(val.Logo_Image);
					document.getElementById('NGOLogo').src = '/Img/SDGs-Academy-white-logo.png';
					document.getElementById('LogoImage1').src = '/Img/SDGs-Academy-white-logo.png';
					document.getElementById('LogoImage3').src = '/Img/SDGs-Academy-white-logo.png';
                }
                if (val.Logo_Image != null & val.Logo_Image != "") {
                    //alert("not equal");
                    document.getElementById('NGOLogo').src = apiBaseUrl+'/NGOLogos/' + val.Logo_Image;
                    document.getElementById('LogoImage1').src = apiBaseUrl+'/NGOLogos/' + val.Logo_Image;
                    document.getElementById('LogoImage3').src = apiBaseUrl+'/NGOLogos/' + val.Logo_Image;
                }
            });
        }
    });

});