$(document).ready(function () {
	var apiBaseUrl = document.getElementById('ApiBaseURL').innerHTML;
	var BaseUrl = document.getElementById('BaseURL').innerHTML;
    var UserID = document.getElementById('lblGUID').innerHTML; 
    $('#CHKSDG1').on('ifChanged', function (e) {
        e.preventDefault(); 
        var Name = document.getElementsByName('Indicatorcheckbox');
        //alert(Name);
        if (this.checked) // if changed state is "CHECKED"
        {
            $('input#SDG1Indicatorcheckbox').iCheck('check');
            document.getElementById("btnSDG1").style.display = "block";
        }
        if (!this.checked) // if changed state is "UnCHECKED"
        {
            document.getElementById("btnSDG1").style.display = "none";
            document.getElementById("SDG1Body").style.display = "none";
            var Class = document.getElementById('ibtnSDG1').className;
            if (Class == "fa fa-minus") {
                $("#ibtnSDG1").removeClass("fa fa-minus").addClass('fa fa-plus');
                $('input#ChkAllSDG1').iCheck('uncheck');
                $('input#SDG1Indicatorcheckbox').iCheck('uncheck');
            }
        }
    });
    $('#CHKSDG2').on('ifChanged', function (e) {
        e.preventDefault();
        var Name = document.getElementsByName('Indicatorcheckbox');
        //alert(Name);
        if (this.checked) // if changed state is "CHECKED"
        {
            $('input#SDG2Indicatorcheckbox').iCheck('check');
            document.getElementById("btnSDG2").style.display = "block";
        }
        if (!this.checked) // if changed state is "UnCHECKED"
        {
            document.getElementById("btnSDG2").style.display = "none";
            document.getElementById("SDG2Body").style.display = "none";
            var Class = document.getElementById('ibtnSDG2').className;
            if (Class == "fa fa-minus") {
                $("#ibtnSDG2").removeClass("fa fa-minus").addClass('fa fa-plus');
                $('input#ChkAllSDG2').iCheck('uncheck');
                $('input#SDG2Indicatorcheckbox').iCheck('uncheck');
            }
        }
    });
    $('#CHKSDG3').on('ifChanged', function (e) {
        e.preventDefault();
        var Name = document.getElementsByName('Indicatorcheckbox');
        //alert(Name);
        if (this.checked) // if changed state is "CHECKED"
        {
            $('input#SDG3Indicatorcheckbox').iCheck('check');
            document.getElementById("btnSDG3").style.display = "block";
        }
        if (!this.checked) // if changed state is "UnCHECKED"
        {
            document.getElementById("btnSDG3").style.display = "none";
            document.getElementById("SDG3Body").style.display = "none";
            var Class = document.getElementById('ibtnSDG3').className;
            if (Class == "fa fa-minus") {
                $("#ibtnSDG3").removeClass("fa fa-minus").addClass('fa fa-plus');
                $('input#ChkAllSDG3').iCheck('uncheck');
                $('input#SDG3Indicatorcheckbox').iCheck('uncheck');
            }
        }
    });
    $('#CHKSDG4').on('ifChanged', function (e) {
        e.preventDefault();
        var Name = document.getElementsByName('Indicatorcheckbox');
        //alert(Name);
        if (this.checked) // if changed state is "CHECKED"
        {
            $('input#SDG4Indicatorcheckbox').iCheck('check');
            document.getElementById("btnSDG4").style.display = "block";
        }
        if (!this.checked) // if changed state is "UnCHECKED"
        {
            document.getElementById("btnSDG4").style.display = "none";
            document.getElementById("SDG4Body").style.display = "none";
            var Class = document.getElementById('ibtnSDG4').className;
            if (Class == "fa fa-minus") {
                $("#ibtnSDG4").removeClass("fa fa-minus").addClass('fa fa-plus');
                $('input#ChkAllSDG4').iCheck('uncheck');
                $('input#SDG4Indicatorcheckbox').iCheck('uncheck');
            }
        }
    });
    $('#CHKSDG5').on('ifChanged', function (e) {
        e.preventDefault();
        var Name = document.getElementsByName('Indicatorcheckbox');
        //alert(Name);
        if (this.checked) // if changed state is "CHECKED"
        {
            $('input#SDG5Indicatorcheckbox').iCheck('check');
            document.getElementById("btnSDG5").style.display = "block";
        }
        if (!this.checked) // if changed state is "UnCHECKED"
        {
            document.getElementById("btnSDG5").style.display = "none";
            document.getElementById("SDG5Body").style.display = "none";
            var Class = document.getElementById('ibtnSDG5').className;
            if (Class == "fa fa-minus") {
                $("#ibtnSDG5").removeClass("fa fa-minus").addClass('fa fa-plus');
                $('input#ChkAllSDG5').iCheck('uncheck');
                $('input#SDG5Indicatorcheckbox').iCheck('uncheck');
            }
        }
    });
    $('#CHKSDG6').on('ifChanged', function (e) {
        e.preventDefault();
        var Name = document.getElementsByName('Indicatorcheckbox');
        //alert(Name);
        if (this.checked) // if changed state is "CHECKED"
        {
            $('input#SDG6Indicatorcheckbox').iCheck('check');
            document.getElementById("btnSDG6").style.display = "block";
        }
        if (!this.checked) // if changed state is "UnCHECKED"
        {
            document.getElementById("btnSDG6").style.display = "none";
            document.getElementById("SDG6Body").style.display = "none";
            var Class = document.getElementById('ibtnSDG6').className;
            if (Class == "fa fa-minus") {
                $("#ibtnSDG6").removeClass("fa fa-minus").addClass('fa fa-plus');
                $('input#ChkAllSDG6').iCheck('uncheck');
                $('input#SDG6Indicatorcheckbox').iCheck('uncheck');
            }
        }
    });
    $('#CHKSDG7').on('ifChanged', function (e) {
        e.preventDefault();
        var Name = document.getElementsByName('Indicatorcheckbox');
        //alert(Name);
        if (this.checked) // if changed state is "CHECKED"
        {
            $('input#SDG7Indicatorcheckbox').iCheck('check');
            document.getElementById("btnSDG7").style.display = "block";
        }
        if (!this.checked) // if changed state is "UnCHECKED"
        {
            document.getElementById("btnSDG7").style.display = "none";
            document.getElementById("SDG7Body").style.display = "none";
            var Class = document.getElementById('ibtnSDG7').className;
            if (Class == "fa fa-minus") {
                $("#ibtnSDG7").removeClass("fa fa-minus").addClass('fa fa-plus');
                $('input#ChkAllSDG7').iCheck('uncheck');
                $('input#SDG7Indicatorcheckbox').iCheck('uncheck');
            }
        }
    });
    $('#CHKSDG8').on('ifChanged', function (e) {
        e.preventDefault();
        var Name = document.getElementsByName('Indicatorcheckbox');
        //alert(Name);
        if (this.checked) // if changed state is "CHECKED"
        {
            $('input#SDG8Indicatorcheckbox').iCheck('check');
            document.getElementById("btnSDG8").style.display = "block";
        }
        if (!this.checked) // if changed state is "UnCHECKED"
        {
            document.getElementById("btnSDG8").style.display = "none";
            document.getElementById("SDG8Body").style.display = "none";
            var Class = document.getElementById('ibtnSDG8').className;
            if (Class == "fa fa-minus") {
                $("#ibtnSDG8").removeClass("fa fa-minus").addClass('fa fa-plus');
                $('input#ChkAllSDG8').iCheck('uncheck');
                $('input#SDG8Indicatorcheckbox').iCheck('uncheck');
            }
        }
    });
    $('#CHKSDG9').on('ifChanged', function (e) {
        e.preventDefault();
        var Name = document.getElementsByName('Indicatorcheckbox');
        //alert(Name);
        if (this.checked) // if changed state is "CHECKED"
        {
            $('input#SDG9Indicatorcheckbox').iCheck('check');
            document.getElementById("btnSDG9").style.display = "block";
        }
        if (!this.checked) // if changed state is "UnCHECKED"
        {
            document.getElementById("btnSDG9").style.display = "none";
            document.getElementById("SDG9Body").style.display = "none";
            var Class = document.getElementById('ibtnSDG9').className;
            if (Class == "fa fa-minus") {
                $("#ibtnSDG9").removeClass("fa fa-minus").addClass('fa fa-plus');
                $('input#ChkAllSDG9').iCheck('uncheck');
                $('input#SDG9Indicatorcheckbox').iCheck('uncheck');
            }
        }
    });
    $('#CHKSDG10').on('ifChanged', function (e) {
        e.preventDefault();
        var Name = document.getElementsByName('Indicatorcheckbox');
        //alert(Name);
        if (this.checked) // if changed state is "CHECKED"
        {
            $('input#SDG10Indicatorcheckbox').iCheck('check');
            document.getElementById("btnSDG10").style.display = "block";
        }
        if (!this.checked) // if changed state is "UnCHECKED"
        {
            document.getElementById("btnSDG10").style.display = "none";
            document.getElementById("SDG10Body").style.display = "none";
            var Class = document.getElementById('ibtnSDG10').className;
            if (Class == "fa fa-minus") {
                $("#ibtnSDG10").removeClass("fa fa-minus").addClass('fa fa-plus');
                $('input#ChkAllSDG10').iCheck('uncheck');
                $('input#SDG10Indicatorcheckbox').iCheck('uncheck');
            }
        }
    });
    $('#CHKSDG11').on('ifChanged', function (e) {
        e.preventDefault();
        var Name = document.getElementsByName('Indicatorcheckbox');
        //alert(Name);
        if (this.checked) // if changed state is "CHECKED"
        {
            $('input#SDG11Indicatorcheckbox').iCheck('check');
            document.getElementById("btnSDG11").style.display = "block";
        }
        if (!this.checked) // if changed state is "UnCHECKED"
        {
            document.getElementById("btnSDG11").style.display = "none";
            document.getElementById("SDG11Body").style.display = "none";
            var Class = document.getElementById('ibtnSDG11').className;
            if (Class == "fa fa-minus") {
                $("#ibtnSDG11").removeClass("fa fa-minus").addClass('fa fa-plus');
                $('input#ChkAllSDG11').iCheck('uncheck');
                $('input#SDG11Indicatorcheckbox').iCheck('uncheck');
            }
        }
    });
    $('#CHKSDG12').on('ifChanged', function (e) {
        e.preventDefault();
        var Name = document.getElementsByName('Indicatorcheckbox');
        //alert(Name);
        if (this.checked) // if changed state is "CHECKED"
        {
            $('input#SDG12Indicatorcheckbox').iCheck('check');
            document.getElementById("btnSDG12").style.display = "block";
        }
        if (!this.checked) // if changed state is "UnCHECKED"
        {
            document.getElementById("btnSDG12").style.display = "none";
            document.getElementById("SDG12Body").style.display = "none";
            var Class = document.getElementById('ibtnSDG12').className;
            if (Class == "fa fa-minus") {
                $("#ibtnSDG12").removeClass("fa fa-minus").addClass('fa fa-plus');
                $('input#ChkAllSDG12').iCheck('uncheck');
                $('input#SDG12Indicatorcheckbox').iCheck('uncheck');
            }
        }
    });
    $('#CHKSDG13').on('ifChanged', function (e) {
        e.preventDefault();
        var Name = document.getElementsByName('Indicatorcheckbox');
        //alert(Name);
        if (this.checked) // if changed state is "CHECKED"
        {
            $('input#SDG13Indicatorcheckbox').iCheck('check');
            document.getElementById("btnSDG13").style.display = "block";
        }
        if (!this.checked) // if changed state is "UnCHECKED"
        {
            document.getElementById("btnSDG13").style.display = "none";
            document.getElementById("SDG13Body").style.display = "none";
            var Class = document.getElementById('ibtnSDG13').className;
            if (Class == "fa fa-minus") {
                $("#ibtnSDG13").removeClass("fa fa-minus").addClass('fa fa-plus');
                $('input#ChkAllSDG13').iCheck('uncheck');
                $('input#SDG13Indicatorcheckbox').iCheck('uncheck');
            }
        }
    });
    $('#CHKSDG14').on('ifChanged', function (e) {
        e.preventDefault();
        var Name = document.getElementsByName('Indicatorcheckbox');
        //alert(Name);
        if (this.checked) // if changed state is "CHECKED"
        {
            $('input#SDG14Indicatorcheckbox').iCheck('check');
            document.getElementById("btnSDG14").style.display = "block";
        }
        if (!this.checked) // if changed state is "UnCHECKED"
        {
            document.getElementById("btnSDG14").style.display = "none";
            document.getElementById("SDG14Body").style.display = "none";
            var Class = document.getElementById('ibtnSDG14').className;
            if (Class == "fa fa-minus") {
                $("#ibtnSDG14").removeClass("fa fa-minus").addClass('fa fa-plus');
                $('input#ChkAllSDG14').iCheck('uncheck');
                $('input#SDG14Indicatorcheckbox').iCheck('uncheck');
            }
        }
    });
    $('#CHKSDG15').on('ifChanged', function (e) {
        e.preventDefault();
        var Name = document.getElementsByName('Indicatorcheckbox');
        //alert(Name);
        if (this.checked) // if changed state is "CHECKED"
        {
            $('input#SDG15Indicatorcheckbox').iCheck('check');
            document.getElementById("btnSDG15").style.display = "block";
        }
        if (!this.checked) // if changed state is "UnCHECKED"
        {
            document.getElementById("btnSDG15").style.display = "none";
            document.getElementById("SDG15Body").style.display = "none";
            var Class = document.getElementById('ibtnSDG15').className;
            if (Class == "fa fa-minus") {
                $("#ibtnSDG15").removeClass("fa fa-minus").addClass('fa fa-plus');
                $('input#ChkAllSDG15').iCheck('uncheck');
                $('input#SDG15Indicatorcheckbox').iCheck('uncheck');
            }
        }
    });
    $('#CHKSDG16').on('ifChanged', function (e) {
        e.preventDefault();
        var Name = document.getElementsByName('Indicatorcheckbox');
        //alert(Name);
        if (this.checked) // if changed state is "CHECKED"
        {
            $('input#SDG16Indicatorcheckbox').iCheck('check');
            document.getElementById("btnSDG16").style.display = "block";
        }
        if (!this.checked) // if changed state is "UnCHECKED"
        {
            document.getElementById("btnSDG16").style.display = "none";
            document.getElementById("SDG16Body").style.display = "none";
            var Class = document.getElementById('ibtnSDG16').className;
            if (Class == "fa fa-minus") {
                $("#ibtnSDG16").removeClass("fa fa-minus").addClass('fa fa-plus');
                $('input#ChkAllSDG16').iCheck('uncheck');
                $('input#SDG16Indicatorcheckbox').iCheck('uncheck');
            }
        }
    });
    $('#CHKSDG17').on('ifChanged', function (e) {
        e.preventDefault();
        var Name = document.getElementsByName('Indicatorcheckbox');
        //alert(Name);
        if (this.checked) // if changed state is "CHECKED"
        {
            $('input#SDG17Indicatorcheckbox').iCheck('check');
            document.getElementById("btnSDG17").style.display = "block";
        }
        if (!this.checked) // if changed state is "UnCHECKED"
        {
            document.getElementById("btnSDG17").style.display = "none";
            document.getElementById("SDG17Body").style.display = "none";
            var Class = document.getElementById('ibtnSDG17').className;
            if (Class == "fa fa-minus") {
                $("#ibtnSDG17").removeClass("fa fa-minus").addClass('fa fa-plus');
                $('input#ChkAllSDG17').iCheck('uncheck');
                $('input#SDG17Indicatorcheckbox').iCheck('uncheck');
            }
        }
    });
    $('#ChkAllSDG1').on('ifChanged', function (e) {
        e.preventDefault();
        var Name = document.getElementsByName('Indicatorcheckbox');
        //alert(Name);
        if (this.checked) // if changed state is "CHECKED"
        {
            $('input#SDG1Indicatorcheckbox').iCheck('check');
        }
        if (!this.checked) // if changed state is "UnCHECKED"
        {
            $('input#SDG1Indicatorcheckbox').iCheck('uncheck');
        }
    });
    $('#ChkAllSDG2').on('ifChanged', function (e) {
        e.preventDefault();
        var Name = document.getElementsByName('Indicatorcheckbox');
        //alert(Name);
        if (this.checked) // if changed state is "CHECKED"
        {
            $('input#SDG2Indicatorcheckbox').iCheck('check');
        }
        if (!this.checked) // if changed state is "UnCHECKED"
        {
            $('input#SDG2Indicatorcheckbox').iCheck('uncheck');
        }
    });
    $('#ChkAllSDG3').on('ifChanged', function (e) {
        e.preventDefault();
        var Name = document.getElementsByName('Indicatorcheckbox');
        //alert(Name);
        if (this.checked) // if changed state is "CHECKED"
        {
            $('input#SDG3Indicatorcheckbox').iCheck('check');
        }
        if (!this.checked) // if changed state is "UnCHECKED"
        {
            $('input#SDG3Indicatorcheckbox').iCheck('uncheck');
        }
    });
    $('#ChkAllSDG4').on('ifChanged', function (e) {
        e.preventDefault();
        var Name = document.getElementsByName('Indicatorcheckbox');
        //alert(Name);
        if (this.checked) // if changed state is "CHECKED"
        {
            $('input#SDG4Indicatorcheckbox').iCheck('check');
        }
        if (!this.checked) // if changed state is "UnCHECKED"
        {
            $('input#SDG4Indicatorcheckbox').iCheck('uncheck');
        }
    });
    $('#ChkAllSDG5').on('ifChanged', function (e) {
        e.preventDefault();
        var Name = document.getElementsByName('Indicatorcheckbox');
        //alert(Name);
        if (this.checked) // if changed state is "CHECKED"
        {
            $('input#SDG5Indicatorcheckbox').iCheck('check');
        }
        if (!this.checked) // if changed state is "UnCHECKED"
        {
            $('input#SDG5Indicatorcheckbox').iCheck('uncheck');
        }
    });
    $('#ChkAllSDG6').on('ifChanged', function (e) {
        e.preventDefault();
        var Name = document.getElementsByName('Indicatorcheckbox');
        //alert(Name);
        if (this.checked) // if changed state is "CHECKED"
        {
            $('input#SDG6Indicatorcheckbox').iCheck('check');
        }
        if (!this.checked) // if changed state is "UnCHECKED"
        {
            $('input#SDG6Indicatorcheckbox').iCheck('uncheck');
        }
    });
    $('#ChkAllSDG7').on('ifChanged', function (e) {
        e.preventDefault();
        var Name = document.getElementsByName('Indicatorcheckbox');
        //alert(Name);
        if (this.checked) // if changed state is "CHECKED"
        {
            $('input#SDG7Indicatorcheckbox').iCheck('check');
        }
        if (!this.checked) // if changed state is "UnCHECKED"
        {
            $('input#SDG7Indicatorcheckbox').iCheck('uncheck');
        }
    });
    $('#ChkAllSDG8').on('ifChanged', function (e) {
        e.preventDefault();
        var Name = document.getElementsByName('Indicatorcheckbox');
        //alert(Name);
        if (this.checked) // if changed state is "CHECKED"
        {
            $('input#SDG8Indicatorcheckbox').iCheck('check');
        }
        if (!this.checked) // if changed state is "UnCHECKED"
        {
            $('input#SDG8Indicatorcheckbox').iCheck('uncheck');
        }
    });
    $('#ChkAllSDG9').on('ifChanged', function (e) {
        e.preventDefault();
        var Name = document.getElementsByName('Indicatorcheckbox');
        //alert(Name);
        if (this.checked) // if changed state is "CHECKED"
        {
            $('input#SDG9Indicatorcheckbox').iCheck('check');
        }
        if (!this.checked) // if changed state is "UnCHECKED"
        {
            $('input#SDG9Indicatorcheckbox').iCheck('uncheck');
        }
    });
    $('#ChkAllSDG10').on('ifChanged', function (e) {
        e.preventDefault();
        var Name = document.getElementsByName('Indicatorcheckbox');
        //alert(Name);
        if (this.checked) // if changed state is "CHECKED"
        {
            $('input#SDG10Indicatorcheckbox').iCheck('check');
        }
        if (!this.checked) // if changed state is "UnCHECKED"
        {
            $('input#SDG10Indicatorcheckbox').iCheck('uncheck');
        }
    });
    $('#ChkAllSDG11').on('ifChanged', function (e) {
        e.preventDefault();
        var Name = document.getElementsByName('Indicatorcheckbox');
        //alert(Name);
        if (this.checked) // if changed state is "CHECKED"
        {
            $('input#SDG11Indicatorcheckbox').iCheck('check');
        }
        if (!this.checked) // if changed state is "UnCHECKED"
        {
            $('input#SDG11Indicatorcheckbox').iCheck('uncheck');
        }
    });
    $('#ChkAllSDG12').on('ifChanged', function (e) {
        e.preventDefault();
        var Name = document.getElementsByName('Indicatorcheckbox');
        //alert(Name);
        if (this.checked) // if changed state is "CHECKED"
        {
            $('input#SDG12Indicatorcheckbox').iCheck('check');
        }
        if (!this.checked) // if changed state is "UnCHECKED"
        {
            $('input#SDG12Indicatorcheckbox').iCheck('uncheck');
        }
    });
    $('#ChkAllSDG13').on('ifChanged', function (e) {
        e.preventDefault();
        var Name = document.getElementsByName('Indicatorcheckbox');
        //alert(Name);
        if (this.checked) // if changed state is "CHECKED"
        {
            $('input#SDG13Indicatorcheckbox').iCheck('check');
        }
        if (!this.checked) // if changed state is "UnCHECKED"
        {
            $('input#SDG13Indicatorcheckbox').iCheck('uncheck');
        }
    });
    $('#ChkAllSDG14').on('ifChanged', function (e) {
        e.preventDefault();
        var Name = document.getElementsByName('Indicatorcheckbox');
        //alert(Name);
        if (this.checked) // if changed state is "CHECKED"
        {
            $('input#SDG14Indicatorcheckbox').iCheck('check');
        }
        if (!this.checked) // if changed state is "UnCHECKED"
        {
            $('input#SDG14Indicatorcheckbox').iCheck('uncheck');
        }
    });
    $('#ChkAllSDG15').on('ifChanged', function (e) {
        e.preventDefault();
        var Name = document.getElementsByName('Indicatorcheckbox');
        //alert(Name);
        if (this.checked) // if changed state is "CHECKED"
        {
            $('input#SDG15Indicatorcheckbox').iCheck('check');
        }
        if (!this.checked) // if changed state is "UnCHECKED"
        {
            $('input#SDG15Indicatorcheckbox').iCheck('uncheck');
        }
    });
    $('#ChkAllSDG16').on('ifChanged', function (e) {
        e.preventDefault();
        var Name = document.getElementsByName('Indicatorcheckbox');
        //alert(Name);
        if (this.checked) // if changed state is "CHECKED"
        {
            $('input#SDG16Indicatorcheckbox').iCheck('check');
        }
        if (!this.checked) // if changed state is "UnCHECKED"
        {
            $('input#SDG16Indicatorcheckbox').iCheck('uncheck');
        }
    });
    $('#ChkAllSDG17').on('ifChanged', function (e) {
        e.preventDefault();
        var Name = document.getElementsByName('Indicatorcheckbox');
        //alert(Name);
        if (this.checked) // if changed state is "CHECKED"
        {
            $('input#SDG17Indicatorcheckbox').iCheck('check');
        }
        if (!this.checked) // if changed state is "UnCHECKED"
        {
            $('input#SDG17Indicatorcheckbox').iCheck('uncheck');
        }
    });
    $(document).on('click', "#btnSDG1", function (event) {
        var Class = document.getElementById('ibtnSDG1').className;
        
        if (Class == "fa fa-plus") // if changed state is "CHECKED"
            {
            document.getElementById("SDG1Body").style.display = "block";
            $("#ibtnSDG1").removeClass("fa fa-plus").addClass('fa fa-minus'); 
            }
        if (Class == "fa fa-minus")
             {
            document.getElementById("SDG1Body").style.display = "none";
            $("#ibtnSDG1").removeClass("fa fa-minus").addClass('fa fa-plus'); 
             }
    });
    $(document).on('click', "#btnSDG2", function (event) {
        var Class = document.getElementById('ibtnSDG2').className;
        if (Class == "fa fa-plus") // if changed state is "CHECKED"
        {
            document.getElementById("SDG2Body").style.display = "block";
            $("#ibtnSDG2").removeClass("fa fa-plus").addClass('fa fa-minus');
        }
        if (Class == "fa fa-minus") {
            document.getElementById("SDG2Body").style.display = "none";
            $("#ibtnSDG2").removeClass("fa fa-minus").addClass('fa fa-plus');
        }
    });
    $(document).on('click', "#btnSDG3", function (event) {
        var Class = document.getElementById('ibtnSDG3').className;
        if (Class == "fa fa-plus") // if changed state is "CHECKED"
        {
            document.getElementById("SDG3Body").style.display = "block";
            $("#ibtnSDG3").removeClass("fa fa-plus").addClass('fa fa-minus');
        }
        if (Class == "fa fa-minus") {
            document.getElementById("SDG3Body").style.display = "none";
            $("#ibtnSDG3").removeClass("fa fa-minus").addClass('fa fa-plus');
        }
    });
    $(document).on('click', "#btnSDG4", function (event) {
        var Class = document.getElementById('ibtnSDG4').className;
        if (Class == "fa fa-plus") // if changed state is "CHECKED"
        {
            document.getElementById("SDG4Body").style.display = "block";
            $("#ibtnSDG4").removeClass("fa fa-plus").addClass('fa fa-minus');
        }
        if (Class == "fa fa-minus") {
            document.getElementById("SDG4Body").style.display = "none";
            $("#ibtnSDG4").removeClass("fa fa-minus").addClass('fa fa-plus');
        }
    });
    $(document).on('click', "#btnSDG5", function (event) {
        var Class = document.getElementById('ibtnSDG5').className;
        if (Class == "fa fa-plus") // if changed state is "CHECKED"
        {
            document.getElementById("SDG5Body").style.display = "block";
            $("#ibtnSDG5").removeClass("fa fa-plus").addClass('fa fa-minus');
        }
        if (Class == "fa fa-minus") {
            document.getElementById("SDG5Body").style.display = "none";
            $("#ibtnSDG5").removeClass("fa fa-minus").addClass('fa fa-plus');
        }
    });
    $(document).on('click', "#btnSDG6", function (event) {
        var Class = document.getElementById('ibtnSDG6').className;
        if (Class == "fa fa-plus") // if changed state is "CHECKED"
        {
            document.getElementById("SDG6Body").style.display = "block";
            $("#ibtnSDG6").removeClass("fa fa-plus").addClass('fa fa-minus');
        }
        if (Class == "fa fa-minus") {
            document.getElementById("SDG6Body").style.display = "none";
            $("#ibtnSDG6").removeClass("fa fa-minus").addClass('fa fa-plus');
        }
    });
    $(document).on('click', "#btnSDG7", function (event) {
        var Class = document.getElementById('ibtnSDG7').className;
        if (Class == "fa fa-plus") // if changed state is "CHECKED"
        {
            document.getElementById("SDG7Body").style.display = "block";
            $("#ibtnSDG7").removeClass("fa fa-plus").addClass('fa fa-minus');
        }
        if (Class == "fa fa-minus") {
            document.getElementById("SDG7Body").style.display = "none";
            $("#ibtnSDG7").removeClass("fa fa-minus").addClass('fa fa-plus');
        }
    });
    $(document).on('click', "#btnSDG8", function (event) {
        var Class = document.getElementById('ibtnSDG8').className;
        if (Class == "fa fa-plus") // if changed state is "CHECKED"
        {
            document.getElementById("SDG8Body").style.display = "block";
            $("#ibtnSDG8").removeClass("fa fa-plus").addClass('fa fa-minus');
        }
        if (Class == "fa fa-minus") {
            document.getElementById("SDG8Body").style.display = "none";
            $("#ibtnSDG8").removeClass("fa fa-minus").addClass('fa fa-plus');
        }
    });
    $(document).on('click', "#btnSDG9", function (event) {
        var Class = document.getElementById('ibtnSDG9').className;
        if (Class == "fa fa-plus") // if changed state is "CHECKED"
        {
            document.getElementById("SDG9Body").style.display = "block";
            $("#ibtnSDG9").removeClass("fa fa-plus").addClass('fa fa-minus');
        }
        if (Class == "fa fa-minus") {
            document.getElementById("SDG9Body").style.display = "none";
            $("#ibtnSDG9").removeClass("fa fa-minus").addClass('fa fa-plus');
        }
    });
    $(document).on('click', "#btnSDG10", function (event) {
        var Class = document.getElementById('ibtnSDG10').className;
        if (Class == "fa fa-plus") // if changed state is "CHECKED"
        {
            document.getElementById("SDG10Body").style.display = "block";
            $("#ibtnSDG10").removeClass("fa fa-plus").addClass('fa fa-minus');
        }
        if (Class == "fa fa-minus") {
            document.getElementById("SDG10Body").style.display = "none";
            $("#ibtnSDG10").removeClass("fa fa-minus").addClass('fa fa-plus');
        }
    });
    $(document).on('click', "#btnSDG11", function (event) {
        var Class = document.getElementById('ibtnSDG11').className;
        if (Class == "fa fa-plus") // if changed state is "CHECKED"
        {
            document.getElementById("SDG11Body").style.display = "block";
            $("#ibtnSDG11").removeClass("fa fa-plus").addClass('fa fa-minus');
        }
        if (Class == "fa fa-minus") {
            document.getElementById("SDG11Body").style.display = "none";
            $("#ibtnSDG11").removeClass("fa fa-minus").addClass('fa fa-plus');
        }
    });
    $(document).on('click', "#btnSDG12", function (event) {
        var Class = document.getElementById('ibtnSDG12').className;
        if (Class == "fa fa-plus") // if changed state is "CHECKED"
        {
            document.getElementById("SDG12Body").style.display = "block";
            $("#ibtnSDG12").removeClass("fa fa-plus").addClass('fa fa-minus');
        }
        if (Class == "fa fa-minus") {
            document.getElementById("SDG12Body").style.display = "none";
            $("#ibtnSDG12").removeClass("fa fa-minus").addClass('fa fa-plus');
        }
    });
    $(document).on('click', "#btnSDG13", function (event) {
        var Class = document.getElementById('ibtnSDG13').className;
        if (Class == "fa fa-plus") // if changed state is "CHECKED"
        {
            document.getElementById("SDG13Body").style.display = "block";
            $("#ibtnSDG13").removeClass("fa fa-plus").addClass('fa fa-minus');
        }
        if (Class == "fa fa-minus") {
            document.getElementById("SDG13Body").style.display = "none";
            $("#ibtnSDG13").removeClass("fa fa-minus").addClass('fa fa-plus');
        }
    });
    $(document).on('click', "#btnSDG14", function (event) {
        var Class = document.getElementById('ibtnSDG14').className;
        if (Class == "fa fa-plus") // if changed state is "CHECKED"
        {
            document.getElementById("SDG14Body").style.display = "block";
            $("#ibtnSDG14").removeClass("fa fa-plus").addClass('fa fa-minus');
        }
        if (Class == "fa fa-minus") {
            document.getElementById("SDG14Body").style.display = "none";
            $("#ibtnSDG14").removeClass("fa fa-minus").addClass('fa fa-plus');
        }
    });
    $(document).on('click', "#btnSDG15", function (event) {
        var Class = document.getElementById('ibtnSDG15').className;
        if (Class == "fa fa-plus") // if changed state is "CHECKED"
        {
            document.getElementById("SDG15Body").style.display = "block";
            $("#ibtnSDG15").removeClass("fa fa-plus").addClass('fa fa-minus');
        }
        if (Class == "fa fa-minus") {
            document.getElementById("SDG15Body").style.display = "none";
            $("#ibtnSDG15").removeClass("fa fa-minus").addClass('fa fa-plus');
        }
    });
    $(document).on('click', "#btnSDG16", function (event) {
        var Class = document.getElementById('ibtnSDG16').className;
        if (Class == "fa fa-plus") // if changed state is "CHECKED"
        {
            document.getElementById("SDG16Body").style.display = "block";
            $("#ibtnSDG16").removeClass("fa fa-plus").addClass('fa fa-minus');
        }
        if (Class == "fa fa-minus") {
            document.getElementById("SDG16Body").style.display = "none";
            $("#ibtnSDG16").removeClass("fa fa-minus").addClass('fa fa-plus');
        }
    });
    $(document).on('click', "#btnSDG17", function (event) {
        var Class = document.getElementById('ibtnSDG17').className;
        if (Class == "fa fa-plus") // if changed state is "CHECKED"
        {
            document.getElementById("SDG17Body").style.display = "block";
            $("#ibtnSDG17").removeClass("fa fa-plus").addClass('fa fa-minus');
        }
        if (Class == "fa fa-minus") {
            document.getElementById("SDG17Body").style.display = "none";
            $("#ibtnSDG17").removeClass("fa fa-minus").addClass('fa fa-plus');
        }
    });
    
   
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
                //alert(val.Organization_Type);
                $("#txtOrganizationName").val(val.Organization_Name);
                $("#drpOrganizationType").val(Organization_Type);
            });
        }
    });
    $("#BtnOfficeRegistrationSubmit").click(function (e) {
        e.preventDefault();
        if ($("#txtOfficeName").val() != '') {

            var Office_Name = $("#txtOfficeName").val();
            var Person_Contact_Name = $("#txtPersonName").val();
            var Person_Contact_Title = $("#txt_Person_Title").val();
            var Person_Contat_Number = $("#txt_Person_Contact").val();
            var Person_Contat_Email = $("#txt_Person_Email").val();
            var Province_Id = $("#drpProvince").val();
            var Division_Id = $("#dprDivision").val();
            var District_Id = $("#drpDistrict").val();
            var Tehsils_Id = $("#drpTehsils").val();
            var UnionCouncils_Id = $("#drpUnionCouncils").val();
            var Street = $("#txtstreet").val();
            var House = $("#txtHouse").val();
            var PostalCode = $("#txtPostalCode").val();

            var items = document.getElementsByName('checkbox');
            var itemsIndicators = document.getElementsByName('Indicatorcheckbox');
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
                Office_Name: Office_Name,
                Person_Contact_Name: Person_Contact_Name,
                Person_Contact_Title: Person_Contact_Title,
                Person_Contat_Number: Person_Contat_Number,
                Person_Contat_Email: Person_Contat_Email,
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
                url: apiBaseUrl+'/AddOfficeRegestration?UserID=' + UserID,
                contentType: 'application/json',
                dataType: 'json',
                data: JSONDATA,
                success: function (data) {
                    //alert("OK");
                    //alert(data);
                    //var jsonObj = JSON.parse(data);
                    //alert(jsonObj);
                    var [OrgID, OfficeID] = data;
                    console.log(OrgID, OfficeID);
                    //alert(OrgID + "," + OfficeID);
                    sendmail(OrgID, OfficeID, Person_Contat_Email);
                    $("#successRegistrationModal").modal("show");
                },
                error: function (jqXHR) {
                    $("#divErrorText").text(jqXHR.responseText);
                    $('#divError').show('fade');
                }

            });
        }
    });
    //Send Email to office registeration
    function sendmail(OrgID, OfficeID, Person_Contat_Email) {
        event.preventDefault();
        $.ajax({
			url: apiBaseUrl+"/SendingMail",
            method: "POST",
            headers: {
                'Content-Type': 'application/x-www-form-urlencoded'
            },
            dataType: "json",
            data: {
                to: Person_Contat_Email,
                subject: "Congratulatiuons! Your Office Register with Us.",
                body: "<html><body><h2>Congratulations!</h2><br><h4> Your Office Register With us! Please click on following Button to set password for your account</h4>" +
				"<a href=\"" + BaseUrl +"/Account/Register?id=" + OrgID + "&OfficeID=" + OfficeID + "\">Complete SignUp</a></body></html>"

            },

            success: function () {
                location.reload(true)
            },

        });
    }
    //ADD Office Email
    $("#BtnOfficeEmailSubmit").click(function (e) {
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
                url: apiBaseUrl+'/ADDOfficeEmail?UserID=' + UserID,
                contentType: 'application/json',
                dataType: 'json',
                data: JSONDATA,
                success: function () {
                    //alert(JSONDATA);
                    $("#OfficeEmailModal").modal("hide");
                    $("#OfficeEmailADDsuccessModal").modal("show");
                    //Grid Bind of Office Email,s
                    $("#OfficeEmails").empty();
                    var Email = $("#OfficeEmails");
                    var id = 1;
                    $.ajax({
                        type: 'Get',
                        url: apiBaseUrl+'/GetOfficeAllEmails?UserID=' + UserID,
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
                                    '<td> <button type="button" class="btn btn-dropbox" id="btnOfficeEmailEdit" title="Edit" data-toggle="modal" data-target="#OfficeEmailModal" value="' + EmailAddressId + '">Edit</button >' +
                                    ' ' + '<button class="btn btn-danger" id="btnOfficeEmailDelete" title="Delete' +
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
    //Grid Bind Office Email
    var Email = $("#OfficeEmails");
    var id = 1;
    $.ajax({
        type: 'Get',
        url: apiBaseUrl+'/GetOfficeAllEmails?UserID=' + UserID,
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
                    '<td> <button type="button" class="btn btn-dropbox" id="btnOfficeEmailEdit" title="Edit" data-toggle="modal" data-target="#OfficeEmailModal" value="' + EmailAddressId + '">Edit</button >' +
                    ' ' + '<button class="btn btn-danger" id="btnOfficeEmailDelete" title="Delete' +
                    '" value="' + EmailAddressId + '">Delete</button> </td>' + '</tr>');
                id++;
            });
        }
    });
    //Grid Bind of Office Contact,s
    var Contact = $("#OfficeContact");
    var id1 = 1;
    $.ajax({
        type: 'Get',
        url: apiBaseUrl+'/GetRegistrOfficeContacts?UserID=' + UserID,
        dataType: 'json',
        success: function (data) {
            //alert(data);
            var JSONDATA = JSON.parse(data);
            $.each(JSONDATA, function (index, val) {
                //alert(val.Contact_Id);
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
                    '<td> <button type="button" class="btn btn-dropbox" id="btnOfficeContactEdit" title="Edit" data-toggle="modal" data-target="#OfficeContactModel" value="' + ContactId + '">Edit</button >' +
                    ' ' + '<button class="btn btn-danger" id="btnOfficeContactDelete" title="Delete'  +
                    '" value="' + ContactId + '">Delete</button> </td>' + '</tr>');
                id1++;
            });
        }
    });
    //ADD Office Contacts
    $("#BtnOfficeContactSubmit").click(function (e) {
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
                url: apiBaseUrl+'/ADDRegisterOfficeContact?UserID=' + UserID,
                contentType: 'application/json',
                dataType: 'json',
                data: JSONDATA,
                success: function () {
                    $("#OfficeContactModel").modal("hide");
                    $("#OfficeContactsuccessModal").modal("show");
                    //Grid Bind of Office Contact,s
                    $("#OfficeContact").empty();
                    var Contact = $("#OfficeContact");
                    var id1 = 1;
                    $.ajax({
                        type: 'Get',
                        url: apiBaseUrl+'/GetRegistrOfficeContacts?UserID=' + UserID,
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
                                    '<td> <button type="button" class="btn btn-dropbox" id="btnOfficeContactEdit" title="Edit" data-toggle="modal" data-target="#OfficeContactModel" value="' + ContactId + '">Edit</button >' +
                                    ' ' + '<button class="btn btn-danger" id="btnOfficeContactDelete" title="Delete' +
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

    //Edit Onclick Office Contact Edit
    $(document).on("click", "#btnOfficeContactEdit", function (e) {
        e.preventDefault();
        var ContactId = $(this).val();
        //alert(ContactId);
        $.ajax({
            type: 'Get',
            url: apiBaseUrl+'/ORGOfficeContact?Contact_Id=' + ContactId,
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
                document.getElementById('BtnOfficeContactSubmit').style.visibility = 'hidden';
                document.getElementById('BtnOfficeContactUpdate').style.visibility = 'visible';
                $("#OfficeContactModel").modal('show');
            }
        });
    });

    //Edit Onclick Office Email Edit
    $(document).on("click", "#btnOfficeEmailEdit", function (e) {
        e.preventDefault();
        var EmailAddressId = $(this).val();
        //alert(ContactId);
        $.ajax({
            type: 'Get',
            url: apiBaseUrl+'/OfficeEmailByID?EmailAddressId=' + EmailAddressId,
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
                document.getElementById('BtnOfficeEmailSubmit').style.visibility = 'hidden';
                document.getElementById('BtnOfficeEmailUpdate').style.visibility = 'visible';
                $("#OfficeEmailModal").modal('show');
            }
        });
    });
    //Update Office Emial Method
    $("#BtnOfficeEmailUpdate").click(function (e) {
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
            url: apiBaseUrl+'/UpdateOfficeEmail?EmailAddressId=' + EmailAddressId + '&UserID='+UserID,
            contentType: 'application/json',
            dataType: 'json',
            data: JSONDATA,
            success: function () {
                //alert(JSONDATA);
                $("#OfficeEmailModal").modal("hide");
                $("#OfficeEmailUpdatesuccessModal").modal("show");
                //Grid Bind Office Email
                $("#OfficeEmails").empty();
                var Email = $("#OfficeEmails");
                var id = 1;
                $.ajax({
                    type: 'Get',
                    url: apiBaseUrl+'/GetOfficeAllEmails?UserID=' + UserID,
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
                                '<td> <button type="button" class="btn btn-dropbox" id="btnOfficeEmailEdit" title="Edit" data-toggle="modal" data-target="#OfficeEmailModal" value="' + EmailAddressId + '">Edit</button >' +
                                ' ' + '<button class="btn btn-danger" id="btnOfficeEmailDelete" title="Delete' +
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

    //Delete OrgContact Method
    $(document).on("click", "#btnOfficeEmailDelete", function (e) {
        e.preventDefault();
        var EmailId = $(this).val();
        $.ajax({
            type: 'POST',
            url: apiBaseUrl+'/DeleteOfficeEmail?Email_Address_Id=' + EmailId + '&UserID=' + UserID,
            dataType: 'json',
            success: function (result) {
                //alert("Data Deleted Successfully!");
                $("#OfficeEmailModal").modal("hide");
                $("#OfficeEmailDeletesuccessModal").modal("show");
                //Grid Bind Office Email
                $("#OfficeEmails").empty();
                var Email = $("#OfficeEmails");
                var id = 1;
                $.ajax({
                    type: 'Get',
                    url: apiBaseUrl+'/GetOfficeAllEmails?UserID=' + UserID,
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
                                '<td> <button type="button" class="btn btn-dropbox" id="btnOfficeEmailEdit" title="Edit" data-toggle="modal" data-target="#OfficeEmailModal" value="' + EmailAddressId + '">Edit</button >' +
                                ' ' + '<button class="btn btn-danger" id="btnOfficeEmailDelete" title="Delete' +
                                '" value="' + EmailAddressId + '">Delete</button> </td>' + '</tr>');
                            id++;
                        });
                    }
                });
            }
        });
    });
    //Update Office Contact Method
    $("#BtnOfficeContactUpdate").click(function () {
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
            url: apiBaseUrl+'/UpdateRegisterOfficeContact?Contact_Id=' + ContactID + '&UserID=' + UserID,
            contentType: 'application/json',
            dataType: 'json',
            data: JSONDATA,
            success: function () {
                //alert(JSONDATA);
                $("#OfficeContactModel").modal("hide");
                $("#OfficeContactUpdatesuccessModal").modal("show");
                //Grid Bind of NGO Contact,s
                $("#OfficeContact").empty();
                var Contact = $("#OfficeContact");
                var id1 = 1;
                $.ajax({
                    type: 'Get',
                    url: apiBaseUrl+'/GetRegistrOfficeContacts?UserID=' + UserID,
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
                                '<td> <button type="button" class="btn btn-dropbox" id="btnOfficeContactEdit" title="Edit" data-toggle="modal" data-target="#OfficeContactModel" value="' + ContactId + '">Edit</button >' +
                                ' ' + '<button class="btn btn-danger" id="btnOfficeContactDelete" title="Delete' + 
                                '" value="' + ContactId + '">Delete</button> </td>' + '</tr>');
                            id1++;
                        });
                    }
                });
                document.getElementById('BtnOfficeContactSubmit').style.visibility = 'hidden';
            },
            error: function (jqXHR) {
                $("#divErrorText").text(jqXHR.responseText);
                $('#divError').show('fade');
            }

        });

    });

    //Delete Office Contact Method
    $(document).on("click", "#btnOfficeContactDelete", function (e) {
        e.preventDefault();
        if ($("txtContactnum").val !='') {
            var ContactId = $(this).val();
            $.ajax({
                type: 'POST',
                url: apiBaseUrl+'/DeleteRegisterOfficeContact?Contact_Id=' + ContactId + '&UserID=' + UserID,
                dataType: 'json',
                success: function (result) {
                    $("#OfficeContactDeletesuccessModal").modal("show");
                    //alert("Data Deleted Successfully!");
                    //Grid Bind of NGO Contact,s
                    $("#OfficeContact").empty();
                    var Contact = $("#OfficeContact");
                    var id1 = 1;
                    $.ajax({
                        type: 'Get',
                        url: apiBaseUrl+'/GetRegistrOfficeContacts?UserID=' + UserID,
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
                                    '<td> <button type="button" class="btn btn-dropbox" id="btnOfficeContactEdit" title="Edit" data-toggle="modal" data-target="#OfficeContactModel" value="' + ContactId + '">Edit</button >' +
                                    ' ' + '<button class="btn btn-danger" id="btnOfficeContactDelete" title="Delete" href="' + link2 +
                                    '" value="' + ContactId + '">Delete</button> </td>' + '</tr>');
                                id1++;
                            });
                        }
                    });
                }
            });
        }
       
    }); 
    
    //OfficeContactInfo Modal
    $(document).on("click", "#btnAddOfficeContactInfo", function () {
        document.getElementById('txtContactnum').value = '';
        document.getElementById('txtFax').value = '';
        document.getElementById('txtWebsite').value = '';
        document.getElementById('BtnClose').style.float = 'Right';
        //document.getElementById('BtnOfficeContactSubmit').style.float = 'Left';
        document.getElementById('BtnOfficeContactSubmit').style.visibility = 'visible';
        document.getElementById('BtnOfficeContactUpdate').style.visibility = 'hidden';
    });
    //EmilAddressInfo Modal
    $(document).on("click", "#BtnAddEmilAddressInfo", function () {
        document.getElementById('txt_email').value = '';
        document.getElementById('Cmb_Types').value = 'Null';
       // document.getElementById('BtnClose').style.float = 'Right';
        //document.getElementById('BtnOfficeContactSubmit').style.float = 'Left';
        document.getElementById('BtnOfficeEmailSubmit').style.visibility = 'visible';
        document.getElementById('BtnOfficeEmailUpdate').style.visibility = 'hidden';
    });
});