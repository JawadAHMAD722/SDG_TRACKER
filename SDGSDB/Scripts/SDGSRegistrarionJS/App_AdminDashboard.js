$(document).ready(function () {
	//Get Total Register Organization
	
	//var apiBaseUrl = '<%= System.Configuration.ConfigurationManager.AppSettings.Get("ApiBaseUrl") %>'
	var apiBaseUrl = document.getElementById('ApiBaseURL').innerHTML;
    $.ajax({
        type: 'Get',
		url: apiBaseUrl+'/GetTotalRegisteredNGOS',
        dataType: 'json',
        success: function (result) {
            //alert(result);
            var JSONDATA = JSON.parse(result);
            document.getElementById('lblTotalRegOrg').innerText = JSONDATA;
        }
    });
    var UserID = document.getElementById('lblGUID').innerHTML;
    //alert(UserID);

    //Get Registered NGO
    $.ajax({
        type: 'Get',
		url: apiBaseUrl+'/GetLoginNGOOfficeInfo?UserID=' + UserID,
        dataType: 'json',
        success: function (result) {
            //var OrgID = document.getElementById('lblLoginNGO').innerText;
            //alert(result);
            if (result == "[]") {
                document.getElementById('lblLoginNGO').innerText = "SDG Tracker Pakistan";
                document.getElementById('lblLoginNGO1').innerText = "SDG Tracker Pakistan";
                document.getElementById('lblLogiNGO2').innerText = "SDG Tracker Pakistan";
                document.getElementById('lblLoginOffice2').innerText = "Application Admin";
                document.getElementById('lblLoginNGOOffice').innerText = "Application Admin";

                document.getElementById('NGOLogo').src = '/Img/SDG-AcademyLOGO.jpg';
                document.getElementById('LogoImage1').src = '/Img/SDG-AcademyLOGO.jpg';
                document.getElementById('LogoImage3').src = '/Img/SDG-AcademyLOGO.jpg';
            }
            var JSONDATA = JSON.parse(result);
            //alert(JSONDATA);
            $.each(JSONDATA, function (index, val) {
               // alert(val.Logo_Image);
                document.getElementById('lblLoginNGO').innerText = val.Organization_Name;
                document.getElementById('lblLoginNGO1').innerText = val.Organization_Name;
                document.getElementById('lblLogiNGO2').innerText = val.Organization_Name;
                document.getElementById('lblLoginOffice2').innerText = val.Office_Name;
                document.getElementById('lblLoginNGOOffice').innerText = val.Office_Name;
                if (val.Logo_Image == null || val.Logo_Image == "") {
                    //alert("Equal");
                    //alert(val.Logo_Image);
                    document.getElementById('NGOLogo').src = '/Images/your-logo-here-512.png';
                    document.getElementById('LogoImage1').src = '/Images/your-logo-here-512.png';
                    document.getElementById('LogoImage3').src = '/Images/your-logo-here-512.png';
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

    //Notification Registration Request
    $(function () {
        $("#PendingRequestTable").dataTable();

    });

    var org = $("#NotificationRequest");
	var id = 1;
	//debugger;
    $.ajax({
        type: 'Get',
		url: apiBaseUrl+'/Pending_Request',
        dataType: 'json',
		success: function (data) {
			//alert(data);
            $.each(data,
                function (index, val) {
                    var name = val.Organization_Name;
                    org.append('<tr>' +
                        '<td>' +
                        id +
                        '</td>' +
                        '<td>' +
                        name +
                        '</td>' +
                        '</tr>');
                    id++;
                });
        }
    });

    //Get Total Register Request
    $.ajax({
        type: 'Get',
		url: apiBaseUrl+'/GetTotalRegisterationRequest',
        dataType: 'json',
        success: function (result) {
            //alert(result);
            var JSONDATA = JSON.parse(result);
            document.getElementById('TotalRequest').innerText = JSONDATA;
            document.getElementById('RegistrationRequest').innerText = JSONDATA;
            
        }
    });
});