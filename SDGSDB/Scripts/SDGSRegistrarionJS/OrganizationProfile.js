$(document).ready(function () {
	var apiBaseUrl = document.getElementById('ApiBaseURL').innerHTML;
	//var apiBaseUrl = '<%= System.Configuration.ConfigurationManager.AppSettings.Get("ApiBaseUrl") %>';
    var UserID = document.getElementById('lblGUID').innerHTML;
    //alert(UserID);
    //Get Registered NGO Profile
    $.ajax({
        type: 'Get',
        url: apiBaseUrl+'/GetOrganizationProfile?UserID=' + UserID,
        dataType: 'json',
        success: function (result) {
            var arraySDG = [];
            var JSONDATA = JSON.parse(result);
            //alert(JSONDATA);
            $.each(JSONDATA, function (index, val) {
                var SDGLIST = val.SDG_Id;
                arraySDG.push(SDGLIST);
                var Organization_Type = val.Organization_Type_Id;
                document.getElementById('lblOrgName').innerText = val.Organization_Name;
                document.getElementById('lblOrgType').innerText = Organization_Type;
                document.getElementById('lblOrgProvince').innerText = val.Province_Name;
                document.getElementById('lblOrgDivision').innerText = val.Division_Name;
                document.getElementById('lblOrgDistrict').innerText = val.District_Name;
                document.getElementById('lblOrgstreet').innerText = val.Street;
                document.getElementById('lblOrHouse').innerText = val.House;
                document.getElementById('lblOrgCode').innerText = val.PostalCode;
                document.getElementById('lblOrgLogo').src = apiBaseUrl+'/NGOLogos/' + val.Logo_Image;

                //alert(val.SDG_Id);
                document.getElementById('lblOrgFocalPerson').innerText = val.Person_Contact_Name;
                document.getElementById('lblOrgDesignation').innerText = val.Person_Contact_Title;
                document.getElementById('lblOrgEmail').innerText = val.Person_Contact_Email;
                document.getElementById('lblOrgFPContact').innerText = val.Person_Contact_Number;
               
               
                
            });
			if (arraySDG.some(SDG => SDG == 1)) {
				$("#SDGS").append('<a href="/Home/No_Poverty"><img src="/Images/SDG-1.png" height="150" style="margin:10px;border-radius:20px;" /></a>')
				//document.getElementById('SDG1').style.visibility = "visible";
			}
			if (arraySDG.some(SDG => SDG == 2)) {
				$("#SDGS").append('<a href="/Home/Zero_Hunger"><img src="/Images/SDG-2.png" height="150" style="margin:10px;border-radius:20px;" /></a>')
				//document.getElementById('SDG2').style.visibility = "visible";
			}
			if (arraySDG.some(SDG => SDG == 3)) {
				$("#SDGS").append('<a href="/Home/Good_Health"><img src="/Images/SDG-3.png" height="150" style="margin:10px;border-radius:20px;" /></a>')
				//document.getElementById('SDG3').style.visibility = "visible";
			}
			if (arraySDG.some(SDG => SDG == 4)) {
				$("#SDGS").append('<a href="/Home/Quality_Education"><img src="/Images/SDG-4.png" height="150" style="margin:10px;border-radius:20px;" /></a>')
				//document.getElementById('SDG4').style.visibility = "visible";
			}
			if (arraySDG.some(SDG => SDG == 5)) {
				$("#SDGS").append('<a href="/Home/Gender_Equality"><img src="/Images/SDG-5.png" height="150" style="margin:10px;border-radius:20px;" /></a>')
				//document.getElementById('SDG5').style.visibility = "visible";
			}
			if (arraySDG.some(SDG => SDG == 6)) {
				$("#SDGS").append('<a href="/Home/Clean_Water"><img src="/Images/SDG-6.png" height="150" style="margin:10px;border-radius:20px;" /></a>')
				//document.getElementById('SDG6').style.visibility = "visible";
			}
			if (arraySDG.some(SDG => SDG == 7)) {
				$("#SDGS").append('<a href="/Home/Affordable_Clean_Energy"><img src="/Images/SDG-7.png" height="150" style="margin:10px;border-radius:20px;" /></a>')
				// document.getElementById('SDG7').style.visibility = "visible";
			}
			if (arraySDG.some(SDG => SDG == 8)) {
				$("#SDGS").append('<a href="/Home/Decent_Work"><img src="/Images/SDG-8.png" height="150" style="margin:10px;border-radius:20px;" /></a>')
				//document.getElementById('SDG8').style.visibility = "visible";
			}
			if (arraySDG.some(SDG => SDG == 9)) {
				$("#SDGS").append('<a href="/Home/Industry_Innovation_Infrastructure"><img src="/Images/SDG-9.png" height="150" style="margin:10px;border-radius:20px;" /></a>')
			}
			if (arraySDG.some(SDG => SDG == 10)) {
				$("#SDGS").append('<a href="/Home/Reduced_Inequalities"><img src="/Images/SDG-10.png" height="150" style="margin:10px;border-radius:20px;" /></a>')
			}
			if (arraySDG.some(SDG => SDG == 11)) {
				$("#SDGS").append('<a href="/Home/Sustainable_Cities"><img src="/Images/SDG-11.png" height="150" style="margin:10px;border-radius:20px;" /></a>')
			}
			if (arraySDG.some(SDG => SDG == 12)) {
				$("#SDGS").append('<a href="/Home/Responsible_Consuption_Production"><img src="/Images/SDG-12.png" height="150" style="margin:10px;border-radius:20px;" /></a>')
			}
			if (arraySDG.some(SDG => SDG == 13)) {
				$("#SDGS").append('<a href="/Home/Climate_Action"><img src="/Images/SDG-13.png" height="150" style="margin:10px;border-radius:20px;" /></a>')
			}
			if (arraySDG.some(SDG => SDG == 14)) {
				$("#SDGS").append('<a href="/Home/Life_Below_Water"><img src="/Images/SDG-14.png" height="150" style="margin:10px;border-radius:20px;" /></a>')
			}
			if (arraySDG.some(SDG => SDG == 15)) {
				$("#SDGS").append('<a href="/Home/Life_On_Land"><img src="/Images/SDG-15.png" height="150" style="margin:10px;border-radius:20px;" /></a>')
			}
			if (arraySDG.some(SDG => SDG == 16)) {
				$("#SDGS").append('<a href="/Home/Peace_Justice"><img src="/Images/SDG-16.png" height="150" style="margin:10px;border-radius:20px;" /></a>')
			}
			if (arraySDG.some(SDG => SDG == 17)) {
				$("#SDGS").append('<a href="/Home/Partnership"><img src="/Images/SDG-17.png" height="150" style="margin:10px;border-radius:20px;" /></a>')
			}
        }
    });

    $(document).on("click", "#bbtnOrgProfileEdit", function (e) {
        e.preventDefault();
        $.ajax({
            type: 'Get',
            url: apiBaseUrl+'/GetOrganizationProfile?UserID=' + UserID,
            dataType: 'json',
            success: function (data) {
                var arraySDG = [];
                //alert(data);
                var JSONDATA = JSON.parse(data);
                $.each(JSONDATA, function (index, val) {
                    var SDGLIST = val.SDG_Id;
                    arraySDG.push(SDGLIST);
                    //alert(arraySDG);
                    var Person_Contact_Title = val.Person_Contact_Title;
                    var Registeration_Date = val.Registeration_Date;
                    var Date = Registeration_Date.substring(0, 10);
                    //alert(Date);
                    $("#txtOrganizationName_Org").val(val.Organization_Name);
                    $("#txtHeadOfficeName_Org").val(val.Organization_Name);
                    $("#drpOrganizationType_Org").val(val.Organization_Type_Id);
                    $("#txt_Person_Title").val(Person_Contact_Title);
                    $("#txtPersonName").val(val.Person_Contact_Name);
                    $("#txt_Person_Contact").val(val.Person_Contact_Number);
                   
                    $("#txtBusiness_Org").val(val.Type_of_Business);
                    $("#txtPactivites_Org").val(val.Planed_Activity);
                    $("#txt_additional_cments_Org").val(val.Additional_Comments);

                    $("#txt_Person_Email_Org").val(val.Person_Contat_Email);
                    $("#drpRegisterationAuthority").val(val.Registeration_Authority);
                    $("#txtRegisterationDate").val(Date);
                    $("#txtLicenseNo").val(val.LicenseNo);
                    $("#drpCompanyCategory").val(val.CompanyCategory);
                    
                    document.getElementById('ProvinceID').innerText = val.Province_Name;
                    document.getElementById('DivisionID').innerText = val.Division_Name;
                    document.getElementById('DistrictID').innerText = val.District_Name;
                    $("#drpProvince").val(val.Province_Id);
                    $("#dprDivision").val(val.Division_Id);
                    $("#drpDistrict").val(val.District_Id);
                    $("#txtstreet").val(val.Street);
                    $("#txtHouse").val(val.House);
                    $("#txtPostalCode").val(val.PostalCode);
                    document.getElementById('LogoImage').src = apiBaseUrl+'/NGOLogos/' + val.Logo_Image;
                    //document.getElementById('LogoImage').style.visibility = '';
                   // $("#exampleInputFile1").val(apiBaseUrl+'/NGOLogos/' + val.Logo_Image);
                });
                alert(arraySDG);
                if (arraySDG.some(SDG => SDG == 1)) {
                    document.getElementById('CHKSDG1').checked === true;
                    if (!$('input[id="CHKSDG1"]').is(':checked')) {
                      //  $("#CHKSDG1").s("checked", "checked");
                        //$('#CHKSDG1').prop("checked", true);
                    }
                }
                if (arraySDG.some(SDG => SDG == 2)) {
                    document.getElementById("CHKSDG2").checked = true;
                }
                if (arraySDG.some(SDG => SDG == 3)) {
                    document.getElementById("CHKSDG3").checked = true;
                }
                if (arraySDG.some(SDG => SDG == 4)) {
                    document.getElementById("CHKSDG4").checked = true;
                }
                if (arraySDG.some(SDG => SDG == 5)) {
                    document.getElementById("CHKSDG5").checked = true;
                }
                if (arraySDG.some(SDG => SDG == 6)) {
                    document.getElementById("CHKSDG6").checked = true;
                }
                if (arraySDG.some(SDG => SDG == 7)) {
                    document.getElementById("CHKSDG7").checked = true;
                }
                if (arraySDG.some(SDG => SDG == 8)) {
                    if (!$('input[name="checkbox"]').is(':checked')) {
                       
                        $('#CHKSDG8').prop("checked", true);
                    }
                }
                if (arraySDG.some(SDG => SDG == 9)) {
                    document.getElementById("CHKSDG9").checked = true;
                }
                if (arraySDG.some(SDG => SDG == 10)) {
                    document.getElementById("CHKSDG10").checked = true;
                }
                if (arraySDG.some(SDG => SDG == 11)) {
                    document.getElementById("CHKSDG11").checked = true;
                }
                if (arraySDG.some(SDG => SDG == 12)) {
                    if (!$('input[name="checkbox"]').is(':checked')) {
                       
                        $('#CHKSDG12').prop("checked", true);
                    }
                }
                if (arraySDG.some(SDG => SDG == 13)) {
                    document.getElementById("CHKSDG13").checked = true;
                }
                if (arraySDG.some(SDG => SDG == 14)) {
                    document.getElementById("CHKSDG14").checked = true;
                }
                if (arraySDG.some(SDG => SDG == 15)) {
                    document.getElementById("CHKSDG15").checked = true;
                }
                if (arraySDG.some(SDG => SDG == 16)) {
                    document.getElementById("CHKSDG16").checked = true;
                }
                if (arraySDG.some(SDG => SDG == 17)) {
                    document.getElementById("CHKSDG17").checked = true;
                }
            }
        });
    });
   
});