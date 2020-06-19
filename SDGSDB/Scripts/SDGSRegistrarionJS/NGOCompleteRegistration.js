$(document).ready(function () {
	var apiBaseUrl = document.getElementById('ApiBaseURL').innerHTML;
	//var apiBaseUrl = '<%= System.Configuration.ConfigurationManager.AppSettings.Get("ApiBaseUrl") %>';
    var UserID = document.getElementById('lblGUID').innerHTML;
    //alert(UserID);
    var org = $("#Organizations");
    var id = 1;
    $("#linkClose").click(function () {
        $("#divError").hide('fade');
    });
    
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
                var Organization_Type = val.Organization_Type_Id;
                //alert(Organization_Type);
                $("#txtOrganizationName_Org").val(val.Organization_Name);
                $("#txtHeadOfficeName_Org").val(val.Organization_Name);
                $("#drpOrganizationType_Org").val(Organization_Type);
                $("#txt_Person_Email_Org").val(val.Person_Contat_Email);
                $("#txtBusiness_Org").val(val.Type_of_Business);
                $("#txtPactivites_Org").val(val.Planed_Activity);
                $("#txt_additional_cments_Org").val(val.Additional_Comments);
            });
        }
    });
    //Add Complete Registration and  Logo Insert
    $("#BtnRegistrationSubmit").click(function (e) {
        e.preventDefault();
        //Image save to folder
        var data = new FormData();
        var file = document.getElementById('exampleInputFile1').files[0];
        data.append("Imgpathsave", file);
        $.ajax({
            type: 'Post',
            url: apiBaseUrl+'/ImageSave',
            contentType: false,
            processData: false,
            data: data,
            success: function (data) {
                //alet(data);
                //alert("Image Save Succesfully");
                var HeadOffice_Name = $("#txtHeadOfficeName_Org").val();
                var Registeration_Authority = $("#drpRegisterationAuthority").val();
                var Registeration_Date = $("#txtRegisterationDate").val();
                var LicenseNo = $("#txtLicenseNo").val();
                var CompanyCategory = $("#drpCompanyCategory").val();
                var Person_Contact_Name = $("#txtPersonName").val();
                var Person_Contact_Title = $("#txt_Person_Title").val();
                var Person_Contat_Number = $("#txt_Person_Contact").val();
                var Person_Contat_Email = $("#txt_Person_Email_Org").val();;
                var BusinessType = $("#txtBusiness_Org").val();
                var Planned_Activities = $("#txtPactivites_Org").val();
                var Additional_Comments = $("#txt_additional_cments_Org").val();
                var Logo_Image = $("#exampleInputFile1").val();
                var Province_Id = $("#drpProvince").val();
                var Division_Id = $("#dprDivision").val();
                var District_Id = $("#drpDistrict").val();
                var Tehsils_Id = $("#drpTehsils").val();
                var UnionCouncils_Id = $("#drpUnionCouncils").val();
                var Street = $("#txtstreet").val();
                var House = $("#txtHouse").val();
                var PostalCode = $("#txtPostalCode").val();

                var items = document.getElementsByName('checkbox');
                var selectedItems = [];
                for (var i = 0; i < items.length; i++) {
                    if (items[i].type == 'checkbox' && items[i].checked == true)
                        selectedItems += items[i].value + ",";
                }
                var ar = selectedItems.split(','); // empty string separator
                console.log(ar);
                //alert(ar);
                //alert(selectedItems);
                //Indicators
                var itemsIndicators = document.getElementsByName('Indicatorcheckbox');
                var selecteditemsIndicators = [];
                for (var i = 0; i < itemsIndicators.length; i++) {
                    if (itemsIndicators[i].type == 'checkbox' && itemsIndicators[i].checked == true)
                        selecteditemsIndicators += itemsIndicators[i].value + ",";
                }
                var br = selecteditemsIndicators.split(','); // empty string separator
                console.log(br);
            //alert(selecteditemsIndicators);
            //alert(br);
                var data = {
                    HeadOffice_Name: HeadOffice_Name,
                    Registeration_Authority: Registeration_Authority,
                    Registeration_Date: Registeration_Date,
                    LicenseNo: LicenseNo,
                    CompanyCategory: CompanyCategory,
                    Person_Contact_Name: Person_Contact_Name,
                    Person_Contact_Title: Person_Contact_Title,
                    Person_Contat_Number: Person_Contat_Number,
                    Person_Contat_Email: Person_Contat_Email,
                    BusinessType: BusinessType,
                    Planned_Activities: Planned_Activities,
                    Additional_Comments: Additional_Comments,
                    Logo_Image: Logo_Image,
                    Province_Id: Province_Id,
                    Division_Id: Division_Id,
                    District_Id: District_Id,
                    Tehsil_Id: Tehsils_Id,
                    UC_Id: UnionCouncils_Id,
                    Street: Street,
                    House: House,
                    PostalCode: PostalCode,
                    SDGSLIST: ar,
                    SDGSINDLIST: br

                };
                var JSONDATA = JSON.stringify(data);
                //alert(JSONDATA);
                $.ajax({
                    type: 'POST',
                    url: apiBaseUrl+'/UpdateCompleteRegestration?UserID=' + UserID,
                    contentType: 'application/json',
                    dataType: 'json',
                    data: JSONDATA,
                    success: function () {
                        //alert("OK");
                        $("#successRegistrationModal").modal("show");
                        window.location.href="/Registration/OrgContactEmail";
                    },
                    error: function (jqXHR) {
                        $("#divErrorText").text(jqXHR.responseText);
                        $('#divError').show('fade');
                    }

                });
            },
            error: function (jqXHR) {
                $("#divErrorText").text(jqXHR.responseText);
                $('#divError').show('fade');
            }
        });
    });

    //ADD Organization Email
    $("#BtnOrgEmailSubmit").click(function (e) {
        e.preventDefault();
        if ($("txt_email").val() != '') {
            var Email_Id = $("#txt_email").val();
            var Email_Type = $("#Cmb_Types").val();

            var data = {
                Email_Id: Email_Id,
                Email_Type: Email_Type
            };
            var JSONDATA = JSON.stringify(data);
            //alert(JSONDATA);
            $.ajax({
                type: 'POST',
                url: apiBaseUrl+'/ADDORegisterNGOEmail?UserID=' + UserID,
                contentType: 'application/json',
                dataType: 'json',
                data: JSONDATA,
                success: function () {
                    $("#OrgEmailModle").modal("hide");
                    $("#OfficeEmailADDsuccessModal").modal("show");
                    //Grid Bind of Organization Email,s
                    $("#OrgEmails").empty();
                    var Email = $("#OrgEmails");
                    var id = 1;
                    $.ajax({
                        type: 'Get',
                        url: apiBaseUrl+'/GetRegistrNGOEmails?UserID=' + UserID,
                        dataType: 'json',
                        success: function (data) {
                            //alert(data);
                            var JSONDATA = JSON.parse(data);
                            $.each(JSONDATA, function (index, val) {
                                // alert(val.Contact_Number);
                                var EmailAddressId = val.Email_Address_Id;
                                var EmailId = val.Email_Id;
                                var EmailType = val.Email_Type;
                                Email.append('<tr>' +
                                    '<th>' + id + '</th>' +
                                    '<td>' + EmailId + '</td>' +
                                    '<td>' + EmailType + '</td>' +
                                    '<td> <button type="button" class="btn btn-dropbox" id="btnOrgEmailEdit" title="Edit" data-toggle="modal" data-target="#OrgEmailModle" value="' + EmailAddressId + '">Edit</button >' +
                                    ' ' + '<button class="btn btn-danger" id="btnOrgEmailDelete" title="Delete' +
                                    '" value="' + EmailAddressId + '">Delete</button> </td>' + '</tr>');
                                id++;
                            });
                        }
                    });
                },
                error: function (jqXHR) {
                    $("#divErrorText").text(jqXHR.responseText);
                    $('#divError').show('fade');
                }

            });
        }

    });
     //Grid Bind of Organization Email,s
    var Email = $("#OrgEmails");
    var id = 1;
    $.ajax({
        type: 'Get',
        url: apiBaseUrl+'/GetRegistrNGOEmails?UserID=' + UserID,
        dataType: 'json',
        success: function (data) {
            //alert(data);
            var JSONDATA = JSON.parse(data);
            $.each(JSONDATA, function (index, val) {
                // alert(val.Contact_Number);
                var EmailAddressId = val.Email_Address_Id;
                var EmailId = val.Email_Id;
                var EmailType = val.Email_Type;
                Email.append('<tr>' +
                    '<th>' + id + '</th>' +
                    '<td>' + EmailId + '</td>' +
                    '<td>' + EmailType + '</td>' +
                    '<td> <button type="button" class="btn btn-dropbox" id="btnOrgEmailEdit" title="Edit" data-toggle="modal" data-target="#OrgEmailModle" value="' + EmailAddressId + '">Edit</button >' +
                    ' ' + '<button class="btn btn-danger" id="btnOrgEmailDelete" title="Delete' +
                    '" value="' + EmailAddressId + '">Delete</button> </td>' + '</tr>');
                id++;
            });
        }
    });
    //Grid Bind Organization Contact
    var Contact = $("#OrgContact");
    var id1 = 1;
    $.ajax({
        type: 'Get',
        url: apiBaseUrl+'/GetRegistrNGOContacts?UserID=' + UserID,
        dataType: 'json',
        success: function (data) {
            //alert(data);
            var JSONDATA = JSON.parse(data);
            $.each(JSONDATA, function (index, val) {
                // alert(val.Contact_Number);
                var ContactId = val.Contact_Id;
                var ContactNumber = val.Contact_Number;
                var Fax = val.Fax;
                var WebsiteURL = val.Website_URL;
                var link = WebsiteURL;
                var link2 = "#";
                Contact.append('<tr>' +
                    '<th>' + id1 + '</th>' +
                    '<td>' + ContactNumber + '</td>' +
                    '<td>' + Fax + '</td>' +
                    '<td> <a href="' + link + '">' + WebsiteURL + '</a> </td >' +
                    '<td> <button type="button" class="btn btn-dropbox" id="btnOrgContactEdit" title="Edit" data-toggle="modal" data-target="#OrgContactModel" value="' + ContactId + '">Edit</button >' +
                    ' ' + '<button class="btn btn-danger" id="btnOrgContactDelete" title="Delete' +
                    '" value="' + ContactId + '">Delete</button> </td>' + '</tr>');
                id1++;
            });
        }
    });
    //ADD Organization Contacts
    $("#BtnOrgContactSubmit").click(function (e) {
        e.preventDefault();
        if ($("#txtContactnum").val() != '') {
            var Contact_Number = $("#txtContactnum").val();
            var Fax = $("#txtFax").val();
            var Website_URL = $("#txtWebsite").val();
            var data = {
                Contact_Number: Contact_Number,
                Fax: Fax,
                Website_URL: Website_URL
            };
            var JSONDATA = JSON.stringify(data);
            //alert(JSONDATA);
            $.ajax({
                type: 'POST',
                url: apiBaseUrl+'/ADDORegisterNGOContact?UserID=' + UserID,
                contentType: 'application/json',
                dataType: 'json',
                data: JSONDATA,
                success: function () {
                    $("#OrgContactModel").modal("hide");
                    $("#OrgContactsuccessModal").modal("show");
                    //Grid Bind of Organization Contact,s
                    $("#OrgContact").empty();
                    var Contact = $("#OrgContact");
                    var id1 = 1;
                    $.ajax({
                        type: 'Get',
                        url: apiBaseUrl+'/GetRegistrNGOContacts?UserID=' + UserID,
                        dataType: 'json',
                        success: function (data) {
                            //alert(data);
                            var JSONDATA = JSON.parse(data);
                            $.each(JSONDATA, function (index, val) {
                                // alert(val.Contact_Number);
                                var ContactId = val.Contact_Id;
                                var ContactNumber = val.Contact_Number;
                                var Fax = val.Fax;
                                var WebsiteURL = val.Website_URL;
                                var link = WebsiteURL;
                                var link2 = "#";
                                Contact.append('<tr>' +
                                    '<th>' + id1 + '</th>' +
                                    '<td>' + ContactNumber + '</td>' +
                                    '<td>' + Fax + '</td>' +
                                    '<td> <a href="' + link + '">' + WebsiteURL + '</a> </td >' +
                                    '<td> <button type="button" class="btn btn-dropbox" id="btnOrgContactEdit" title="Edit" data-toggle="modal" data-target="#OrgContactModel" value="' + ContactId + '">Edit</button >' +
                                    ' ' + '<button class="btn btn-danger" id="btnOrgContactDelete" title="Delete' +
                                    '" value="' + ContactId + '">Delete</button> </td>' + '</tr>');
                                id1++;
                            });
                        }
                    });
                },
                error: function (jqXHR) {
                    $("#divErrorText").text(jqXHR.responseText);
                    $('#divError').show('fade');
                }

            });

        }
    });

    //Edit Onclick Organization Contact Edit
    $(document).on("click", "#btnOrgContactEdit", function (e) {
        e.preventDefault();
        var ContactId = $(this).val();
        //alert(ContactId);
        $.ajax({
            type: 'Get',
            url: apiBaseUrl+'/ORGHeadOfficeContactByID?Contact_Id=' + ContactId,
            dataType: 'json',
            success: function (result) {
                var JSONDATA = JSON.parse(result)
                //alert(JSONDATA);
                $.each(JSONDATA, function (index, val) {
                    var ContactNumber = val.Contact_Number;
                    var Fax = val.Fax;
                    var WebsiteURL = val.Website_URL;
                    document.getElementById('lblContactID').innerHTML = ContactId;
                    $("#txtContactnum").val(ContactNumber);
                    $("#txtFax").val(Fax);
                    $("#txtWebsite").val(WebsiteURL);
                });
                document.getElementById('BtnOrgContactSubmit').style.visibility = 'hidden';
                document.getElementById('BtnOrgContactUpdate').style.visibility = 'visible';
                $("#OrgContactModel").modal('show');
            }
        });
    });

    //Edit Onclick Organization Email Edit
    $(document).on("click", "#btnOrgEmailEdit", function (e) {
        e.preventDefault();
        var EmailAddressId = $(this).val();
        //alert(ContactId);
        $.ajax({
            type: 'Get',
            url: apiBaseUrl+'/ORGHeadOfficeEmailByID?Email_Address_Id=' + EmailAddressId,
            dataType: 'json',
            success: function (data) {
                //alert(data);
                var JSONDATA = JSON.parse(data);
                $.each(JSONDATA, function (index, val) {
                    var EmailID = val.Email_Id;
                    var EmailType = val.Email_Type;
                    document.getElementById('lblEmailID').innerHTML = EmailAddressId;
                    $("#txt_email").val(EmailID);
                    $("#Cmb_Types").val(EmailType);
                });
                document.getElementById('BtnOrgEmailSubmit').style.visibility = 'hidden';
                document.getElementById('BtnOrgEmailUpdate').style.visibility = 'visible';
                $("#OrgEmailModle").modal('show');
            }
        });
    });
    //Update Organization Emial Method
    $("#BtnOrgEmailUpdate").click(function (e) {
        e.preventDefault();
        var Email_Id = $("#txt_email").val();
        var Email_Type = $("#Cmb_Types").val();
        var EmailAddressId = document.getElementById('lblEmailID').innerText;
        var data = {
            Email_Address_Id: EmailAddressId,
            Email_Id: Email_Id,
            Email_Type: Email_Type
        };
        //alert(EmailAddressId);

        var JSONDATA = JSON.stringify(data);
        //var ButtonText = $("#BtnContactSubmit").text();
        //alert(JSONDATA);
        $.ajax({
            type: 'POST',
            url: apiBaseUrl+'/UpdateRegisterOrgEmail?EmailAddressId=' + EmailAddressId + '&UserID=' + UserID,
            contentType: 'application/json',
            dataType: 'json',
            data: JSONDATA,
            success: function () {
                //alert(JSONDATA);
                $("#OrgEmailModle").modal("hide");
                $("#OrgEmailUpdatesuccessModal").modal("show");
                //Grid Bind of Organization Email,s
                $("#OrgEmails").empty();
                var Email = $("#OrgEmails");
                var id = 1;
                $.ajax({
                    type: 'Get',
                    url: apiBaseUrl+'/GetRegistrNGOEmails?UserID=' + UserID,
                    dataType: 'json',
                    success: function (data) {
                        //alert(data);
                        var JSONDATA = JSON.parse(data);
                        $.each(JSONDATA, function (index, val) {
                            // alert(val.Contact_Number);
                            var EmailAddressId = val.Email_Address_Id;
                            var EmailId = val.Email_Id;
                            var EmailType = val.Email_Type;
                            Email.append('<tr>' +
                                '<th>' + id + '</th>' +
                                '<td>' + EmailId + '</td>' +
                                '<td>' + EmailType + '</td>' +
                                '<td> <button type="button" class="btn btn-dropbox" id="btnOrgEmailEdit" title="Edit" data-toggle="modal" data-target="#OrgEmailModle" value="' + EmailAddressId + '">Edit</button >' +
                                ' ' + '<button class="btn btn-danger" id="btnOrgEmailDelete" title="Delete' +
                                '" value="' + EmailAddressId + '">Delete</button> </td>' + '</tr>');
                            id++;
                        });
                    }
                });
            },
            error: function (jqXHR) {
                $("#divErrorText").text(jqXHR.responseText);
                $('#divError').show('fade');
            }

        });

    });

    //Delete OrgEmail Method
    $(document).on("click", "#btnOrgEmailDelete", function (e) {
        e.preventDefault();
        var EmailId = $(this).val();
        $.ajax({
            type: 'POST',
            url: apiBaseUrl+'/DeleteRegisterOrgEmail?Email_Address_Id=' + EmailId + '&UserID=' + UserID,
            dataType: 'json',
            success: function (result) {
                //alert("Data Deleted Successfully!");
                $("#OrgEmailModle").modal("hide");
                $("#OrgEmailDeletesuccessModal").modal("show");
                //Grid Bind of Organization Email,s
                $("#OrgEmails").empty();
                var Email = $("#OrgEmails");
                var id = 1;
                $.ajax({
                    type: 'Get',
                    url: apiBaseUrl+'/GetRegistrNGOEmails?UserID=' + UserID,
                    dataType: 'json',
                    success: function (data) {
                        //alert(data);
                        var JSONDATA = JSON.parse(data);
                        $.each(JSONDATA, function (index, val) {
                            // alert(val.Contact_Number);
                            var EmailAddressId = val.Email_Address_Id;
                            var EmailId = val.Email_Id;
                            var EmailType = val.Email_Type;
                            Email.append('<tr>' +
                                '<th>' + id + '</th>' +
                                '<td>' + EmailId + '</td>' +
                                '<td>' + EmailType + '</td>' +
                                '<td> <button type="button" class="btn btn-dropbox" id="btnOrgEmailEdit" title="Edit" data-toggle="modal" data-target="#OrgEmailModle" value="' + EmailAddressId + '">Edit</button >' +
                                ' ' + '<button class="btn btn-danger" id="btnOrgEmailDelete" title="Delete' +
                                '" value="' + EmailAddressId + '">Delete</button> </td>' + '</tr>');
                            id++;
                        });
                    }
                });
            }
        });
    });
    //Update Organization Contact Method
    $("#BtnOrgContactUpdate").click(function () {
        event.preventDefault();
        var Contact_Number = $("#txtContactnum").val();
        var Fax = $("#txtFax").val();
        var Website_URL = $("#txtWebsite").val();
        var ContactID = document.getElementById('lblContactID').innerText;
        //alert(ContactID);
        var data = {
            Contact_Number: Contact_Number,
            Fax: Fax,
            Website_URL: Website_URL
        };
        var JSONDATA = JSON.stringify(data);
        //alert(ButtonText);
        $.ajax({
            type: 'POST',
            url: apiBaseUrl+'/UpdateRegisterOrgContact?Contact_Id=' + ContactID + '&UserID=' + UserID,
            contentType: 'application/json',
            dataType: 'json',
            data: JSONDATA,
            success: function () {
                //alert(JSONDATA);
                $("#OrgContactModel").modal("hide");
                $("#OrgContactUpdatesuccessModal").modal("show");
                //Grid Bind of Organization Contact,s
                $("#OrgContact").empty();
                var Contact = $("#OrgContact");
                var id1 = 1;
                $.ajax({
                    type: 'Get',
                    url: apiBaseUrl+'/GetRegistrNGOContacts?UserID=' + UserID,
                    dataType: 'json',
                    success: function (data) {
                        //alert(data);
                        var JSONDATA = JSON.parse(data);
                        $.each(JSONDATA, function (index, val) {
                            // alert(val.Contact_Number);
                            var ContactId = val.Contact_Id;
                            var ContactNumber = val.Contact_Number;
                            var Fax = val.Fax;
                            var WebsiteURL = val.Website_URL;
                            var link = WebsiteURL;
                            var link2 = "#";
                            Contact.append('<tr>' +
                                '<th>' + id1 + '</th>' +
                                '<td>' + ContactNumber + '</td>' +
                                '<td>' + Fax + '</td>' +
                                '<td> <a href="' + link + '">' + WebsiteURL + '</a> </td >' +
                                '<td> <button type="button" class="btn btn-dropbox" id="btnOrgContactEdit" title="Edit" data-toggle="modal" data-target="#OrgContactModel" value="' + ContactId + '">Edit</button >' +
                                ' ' + '<button class="btn btn-danger" id="btnOrgContactDelete" title="Delete' +
                                '" value="' + ContactId + '">Delete</button> </td>' + '</tr>');
                            id1++;
                        });
                    }
                });
                document.getElementById('BtnOrgContactSubmit').style.visibility = 'hidden';
            },
            error: function (jqXHR) {
                $("#divErrorText").text(jqXHR.responseText);
                $('#divError').show('fade');
            }

        });

    });

    //Delete Organization Contact Method
    $(document).on("click", "#btnOrgContactDelete", function (e) {
        e.preventDefault();
        if ($("txtContactnum").val != '') {
            var ContactId = $(this).val();
            $.ajax({
                type: 'POST',
                url: apiBaseUrl+'/DeleteRegisterOrgContact?Contact_Id=' + ContactId + '&UserID=' + UserID,
                dataType: 'json',
                success: function (result) {
                    $("#OrgContactDeletesuccessModal").modal("show");
                    //alert("Data Deleted Successfully!");
                    //Grid Bind of Organization Contact,s
                    $("#OrgContact").empty();
                    var Contact = $("#OrgContact");
                    var id1 = 1;
                    $.ajax({
                        type: 'Get',
                        url: apiBaseUrl+'/GetRegistrNGOContacts?UserID=' + UserID,
                        dataType: 'json',
                        success: function (data) {
                            //alert(data);
                            var JSONDATA = JSON.parse(data);
                            $.each(JSONDATA, function (index, val) {
                                // alert(val.Contact_Number);
                                var ContactId = val.Contact_Id;
                                var ContactNumber = val.Contact_Number;
                                var Fax = val.Fax;
                                var WebsiteURL = val.Website_URL;
                                var link = WebsiteURL;
                                var link2 = "#";
                                Contact.append('<tr>' +
                                    '<th>' + id1 + '</th>' +
                                    '<td>' + ContactNumber + '</td>' +
                                    '<td>' + Fax + '</td>' +
                                    '<td> <a href="' + link + '">' + WebsiteURL + '</a> </td >' +
                                    '<td> <button type="button" class="btn btn-dropbox" id="btnOrgContactEdit" title="Edit" data-toggle="modal" data-target="#OrgContactModel" value="' + ContactId + '">Edit</button >' +
                                    ' ' + '<button class="btn btn-danger" id="btnOrgContactDelete" title="Delete' +
                                    '" value="' + ContactId + '">Delete</button> </td>' + '</tr>');
                                id1++;
                            });
                        }
                    });
                }
            });
        }

    });

    //OrganizationContactInfo Modal
    $(document).on("click", "#btnAddOrgContactInfo", function () {
        document.getElementById('txtContactnum').value = '';
        document.getElementById('txtFax').value = '';
        document.getElementById('txtWebsite').value = '';
        //document.getElementById('BtnClose').style.float = 'Right';
        document.getElementById('BtnOrgContactSubmit').style.visibility = 'visible';
        document.getElementById('BtnOrgContactUpdate').style.visibility = 'hidden';
    });
    //OrganizationEmilAddressInfo Modal
    $(document).on("click", "#BtnAddOrgEmilAddressInfo", function () {
        document.getElementById('txt_email').value = '';
        document.getElementById('Cmb_Types').value = 'Null';
        document.getElementById('BtnOrgEmailSubmit').style.visibility = 'visible';
        document.getElementById('BtnOrgEmailUpdate').style.visibility = 'hidden';
    });
	
});