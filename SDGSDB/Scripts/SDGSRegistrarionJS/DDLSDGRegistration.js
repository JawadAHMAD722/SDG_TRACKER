$(document).ready(function () {
	var apiBaseUrl = document.getElementById('ApiBaseURL').innerHTML;
	//var apiBaseUrl = '<%= System.Configuration.ConfigurationManager.AppSettings.Get("ApiBaseUrl") %>'
    //DDL Province Biding
    var Province = $("#drpProvince")
    $.ajax({
        type: 'Get',
        url: apiBaseUrl+'/GetProvince',
        dataType: 'json',
        success: function (result) {
            //alert(result);
            var JSONDATA = JSON.parse(result);
            //alert(JSONDATA);
            $.each(JSONDATA, function (index, val) {
                var P_id = val.Province_Id;
                var P_name = val.Province_Name;
                Province.append("<option value=" + P_id + ">" + P_name + "</option>");
            });
        }
    });
    //DDL Divisions Biding
    
    $("#drpProvince").on("change", function () {
        document.getElementById("dprDivision").options.length = 0;
        var Divisions = $("#dprDivision")
        var ProvinceID = $("#drpProvince :selected").val()
        //alert(ProvinceID);
        $.ajax({
            type: 'Get',
            url: apiBaseUrl+'/GetDivisionsByID?Province_Id=' + ProvinceID,
            dataType: 'json',
            success: function (result) {
                //alert(result);
                var JSONDATA = JSON.parse(result);
                //alert(JSONDATA);
                
                $.each(JSONDATA, function (index, val) {
                    var Divison_Id = val.Divison_Id;
                    var Division_Name = val.Division_Name;
                    Divisions.append("<option value=" + Divison_Id + ">" + Division_Name + "</option>");
                });
            }
        });
    });
   
    //DDL Districts Biding

    $("#dprDivision").on("change", function () {
        document.getElementById("drpDistrict").options.length = 0;
        var Districts = $("#drpDistrict")
        var DivisionID = $("#dprDivision :selected").val()
        //alert(DivisionID);
        $.ajax({
            type: 'Get',
            url: apiBaseUrl+'/GetDistrictsByDivisions?Division_Id=' + DivisionID,
            dataType: 'json',
            success: function (result) {
                //alert(result);
                var JSONDATA = JSON.parse(result);
                //alert(JSONDATA);

                $.each(JSONDATA, function (index, val) {
                    var District_Id = val.District_Id;
                    var District_Name = val.District_Name;
                    Districts.append("<option value=" + District_Id + ">" + District_Name + "</option>");
                });
            }
        });
    });


    //DDL Tehsils Biding

    $("#drpDistrict").on("change", function () {
        document.getElementById("drpTehsils").options.length = 0;
        var Tehsils = $("#drpTehsils")
        var DistrictID = $("#drpDistrict :selected").val()
        //alert(DivisionID);
        $.ajax({
            type: 'Get',
            url: apiBaseUrl+'/GetTehsilsByDistricts?DistrictID=' + DistrictID,
            dataType: 'json',
            success: function (result) {
                //alert(result);
                var JSONDATA = JSON.parse(result);
                //alert(JSONDATA);

                $.each(JSONDATA, function (index, val) {
                    var Tehsil_Id = val.Tehsil_Id;
                    var Tehsil_Name = val.Tehsil_Name;
                    Tehsils.append("<option value=" + Tehsil_Id + ">" + Tehsil_Name + "</option>");
                });
            }
        });
    });


    //DDL Union Councils Biding

    $("#drpDistrict").on("change", function () {
        document.getElementById("drpUnionCouncils").options.length = 0;
        var UnionCouncils = $("#drpUnionCouncils")
        var DistrictID = $("#drpDistrict :selected").val()
        //alert(DivisionID);
        $.ajax({
            type: 'Get',
            url: apiBaseUrl+'/GetUnionCouncilsByDistricts?DistrictID=' + DistrictID,
            dataType: 'json',
            success: function (result) {
                //alert(result);
                var JSONDATA = JSON.parse(result);
                //alert(JSONDATA);

                $.each(JSONDATA, function (index, val) {
                    var UC_Id = val.UC_Id;
                    var UC_Name = val.UC_Name;
                    UnionCouncils.append("<option value=" + UC_Id + ">" + UC_Name + "</option>");
                });
            }
        });
    });


    //DDL SDG Biding
    var SDG = $("#drpSDG")
    $.ajax({
        type: 'Get',
        url: apiBaseUrl+'/GetSDGS',
        dataType: 'json',
        success: function (result) {
            //alert(result);
            var JSONDATA = JSON.parse(result);
            //alert(JSONDATA);
            $.each(JSONDATA, function (index, val) {
                var SDG_Id = val.SDG_Id;
                var SDG_Name = val.SDG_Name;
                SDG.append("<option value=" + SDG_Id + ">" + SDG_Name + "</option>");
            });
        }
    });

    //DDL Target Biding

    $("#drpSDG").on("change", function () {
        document.getElementById("drpTargets").options.length = 0;
        var Targets = $("#drpTargets")
        var SDGID = $("#drpSDG :selected").val()
        //alert(ProvinceID);
        $.ajax({
            type: 'Get',
            url: apiBaseUrl+'/GetTargets?SDG_Id=' + SDGID,
            dataType: 'json',
            success: function (result) {
                //alert(result);
                var JSONDATA = JSON.parse(result);
                alert(JSONDATA);

                $.each(JSONDATA, function (index, val) {
                    var Target_Id = val.Target_Id;
                    var Target_Name = val.Target_Name;
                    Targets.append("<option value=" + Target_Id + ">" + Target_Name + "</option>");
                });
            }
        });
    });

    //DDL Indicators Biding

    $("#drpTargets").on("change", function () {
        document.getElementById("drpIdicators").options.length = 0;
        var Idicators = $("#drpIdicators")
        var TargetID = $("#drpTargets :selected").val()
        //alert(ProvinceID);
        $.ajax({
            type: 'Get',
            url: apiBaseUrl+'/GetIndicators?Target_Id=' + TargetID,
            dataType: 'json',
            success: function (result) {
                //alert(result);
                var JSONDATA = JSON.parse(result);
                //alert(JSONDATA);

                $.each(JSONDATA, function (index, val) {
                    var Indicator_Id = val.Indicator_Id;
                    var Indicator_Name = val.Indicator_Name;
                    Idicators.append("<option value=" + Indicator_Id + ">" + Indicator_Name + "</option>");
                });
            }
        });
    });

    //DDL Organization Type Binding
    var OrgType = $("#drpOrganizationType")
    $.ajax({
        type: 'Get',
        url: apiBaseUrl+'/GetOrganizationType',
        dataType: 'json',
        success: function (data) {
           // alert(data);
            var OrgDATA = JSON.parse(data);
            //alert(JSONDATA);
            $.each(OrgDATA, function (index, val) {
                var Organization_Type_Id = val.Organization_Type_Id;
                var Organization_Type = val.Organization_Type;
                OrgType.append("<option value=" + Organization_Type_Id + ">" + Organization_Type + "</option>");
            });
        }
    });


    

    
    //Edit Onclick OrgContact Edit
    $(document).on("click", "#btnOrgEdit", function () {
        var ContactId = $(this).val();
        //alert(ContactId);
        $.ajax({
            type: 'Get',
            url: apiBaseUrl+'/ORGHeadOfficeContact?Contact_Id=' + ContactId,
            dataType: 'json',
            success: function (result) {
                var JSONDATA = JSON.parse(result)
                //alert(result);
                $.each(JSONDATA, function (index, val) {
                    var ContactNumber = val.Contact_Number;
                    var Fax = val.Fax;
                    var WebsiteURL = val.Website_URL;
                    document.getElementById('lblContactID').innerHTML = ContactId;
                    $("#txtContactnum").val(ContactNumber);
                    $("#txtFax").val(Fax);
                    $("#txtWebsite").val(WebsiteURL);

                });
                document.getElementById('BtnContactSubmit').style.visibility = 'hidden';
                document.getElementById('BtnContactUpdate').style.visibility = 'visible';
                //$("#BtnContactSubmit").html("Update");
                //var element = document.getElementById('BtnContactSubmit');
                //element.setAttribute('id', 'BtnContactUpdate');
                $("#ContactModel").modal('show');
            }
        });
    });


    $(document).on("click", "#btnAddContactInfo", function () {
        document.getElementById('BtnContactSubmit').style.visibility = 'visible';
        document.getElementById('BtnContactUpdate').style.visibility = 'hidden'; 
    });
    //Delete OrgContact Method
    $(document).on("click", "#btnDelete", function () {
        var ContactId = $(this).val();
        $.ajax({
            type: 'POST',
            url: apiBaseUrl+'/DeleteRegisterOrgContact?Contact_Id=' + ContactId,
            dataType: 'json',
            success: function (result) {
                alert("Data Deleted Successfully!");
            }
        });
    });

    //Update OrgContact Method
    
});