$(document).ready(function () {
    var apiBaseUrl = document.getElementById('ApiBaseURL').innerHTML;
    var BaseUrl = document.getElementById('BaseURL').innerHTML;
    var UserID = document.getElementById('lblGUID').innerHTML;
    $('#txtDOB').datepicker();
    $('#txtJoiningDate').datepicker();
    $('#txtFromDate').datepicker();
    $('#txtTODate').datepicker();
    //alert(UserID);
    //ADD Employee
    $("#btnEmployeeSubmit").click(function (e) {
        e.preventDefault();
       // alert("OK");
        if ($("#txtEmployeeFName").val() != '') {
            var EmployeeName = $("#txtEmployeeFName").val() + ' ' + $("#txtEmployeeLName").val();
            var FatherHusbandName = $("#txtFatherHusbandName").val();
            var Gender = $("#drpGender").val();
            var DOB = $("#txtDOB").val();
            var Nationality = $("#drpNationality").val();
            var BirthPlace = $("#txtBirthPlace").val();
            var CNIC = $("#txtCNIC").val();
            var MaritialStatus = $("#drpmarital_status").val();
            var Height = $("#txtHeight").val();
            var BloodGroup = $("#drpBloodGroup").val();
            var IdentificationMark = $("#txtIdentificationMark").val();
            var Religion = $("#txtReligion").val();
            var Qualification = $("#txtQualification").val();
            var Joining_Date = $("#txtJoiningDate").val();
            var Designation = $("#txtDesignation").val();
            var SectionId = $("#drpSection").val();
            var Person_Contat_Email = $("#txtEmailID").val();
            var Contact_Number = $("#txtContact").val();
            var TemporaryAddress = $("#txtTemporary_Address").val();
            var PerminantAddress = $("#txtPerminant_Address").val();
            var Is_terminated = document.getElementById("IsTerminated").checked
            var TerminatingDate = $("#txtTerminatingDate").val();
            var Reason = $("#txtReason").val();
            var Note = $("#txtNote").val();
            var BomItems = [];
            $('#ExpDataTable tr').each(function (row, tr) {
                BomItems.push({
                    //counter: $(tr).find('td:eq(0)').text().trim(),
                    Position: $(tr).find('td:eq(1)').text().trim(),
                    OrganizationName: $(tr).find('td:eq(2)').text(),
                    FromDate: $(tr).find('td:eq(3)').text(),
                    ToDate: $(tr).find('td:eq(4)').text(),
                });
            });
            //var br = BomItems.split(',');
            //console.log(BomItems);
            var data = {
                Name: EmployeeName,
                FatherHusbandName: FatherHusbandName,
                Gender: Gender,
                DOB: DOB,
                Nationality: Nationality,
                BirthPlace: BirthPlace,
                CNIC: CNIC,
                MaritialStatus: MaritialStatus,
                Height: Height,
                BloodGroup: BloodGroup,
                IdentificationMark: IdentificationMark,
                Religion: Religion,
                Qualification: Qualification,
                Joining_Date: Joining_Date,
                Designation: Designation,
                SectionId: SectionId,
                Person_Contat_Email: Person_Contat_Email,
                Contact_Number: Contact_Number,
                TemporaryAddress: TemporaryAddress,
                PerminantAddress: PerminantAddress,
                Is_terminated: Is_terminated,
                TerminatingDate: TerminatingDate,
                Reason: Reason,
                Note: Note,
                BomItems: BomItems
            };
            //alert(data);
            var JSONDATA = JSON.stringify(data);
            //alert(JSONDATA);
            //alert(Is_terminated);
            //alert(TerminatingDate);
            //alert(Reason);
            $.ajax({
                type: 'POST',
                url: apiBaseUrl + '/AddEmployee?UserID=' + UserID,
                contentType: 'application/json',
                dataType: 'json',
                data: JSONDATA,
                success: function () {
                    //alert(JSONDATA);
                    $("#txtFatherHusbandName").val('');
                    $("#drpGender").val('');
                    $("#txtDOB").val('');
                    $("#drpNationality").val('');
                    $("#txtBirthPlace").val('');
                    $("#txtCNIC").val('');
                    $("#drpmarital_status").val('');
                    $("#txtHeight").val('');
                    $("#drpBloodGroup").val('');
                    $("#txtIdentificationMark").val('');
                    $("#txtReligion").val('');
                    $("#txtQualification").val('');
                    $("#txtJoiningDate").val('');
                    $("#txtDesignation").val('');
                    $("#drpSection").val('');
                    $("#txtEmailID").val('');
                    $("#txtContact").val('');
                    $("#txtTemporary_Address").val('');
                    $("#txtPerminant_Address").val('');
                    $('input#IsTerminated').iCheck('uncheck');
                    $("#txtTerminatingDate").val('');
                    $("#txtReason").val('');
                    $("#txtNote").val('');
                    document.getElementById('EmpDIVSuccess').style.visibility = 'visible';
                },
                error: function (jqXHR) {
                    $("#divErrorText").text(jqXHR.responseText);
                    $('#divError').show('fade');
                }

            });
        }

    });
    $('#IsTerminated').on('ifChanged', function (event) {
        var checkBox = document.getElementsByName('IsTerminated');
        var TerminationDate = document.getElementById("DivTerminationDate");
        var DivReason = document.getElementById("DivReason");
        if (this.checked) // if changed state is "CHECKED"
        {
            TerminationDate.style.display = "block";
            DivReason.style.display = "block";
        }
        else
        {
            TerminationDate.style.display = "none";
            DivReason.style.display = "none";
        }
    });
    $(document).on("click", "#IsTerminated", function (e) {
        e.preventDefault();
        //alert("OK");
        var checkBox = document.getElementsByName('IsTerminated');
        var text = document.getElementById("DivTerminationDate");
        alert(checkBox);
        if (checkBox.checked == true) {
            text.style.display = "block";
        } else {
            text.style.display = "none";
        }
    });
   
});