  
$(document).ready(function () {
    alert("Welcome");


    $("#UserimgId").on("change", function () {
        //alert("Onchange event fired");

        let fileControl = event.target;
        let fileList = fileControl.files;

        let firstFile = fileList[0];

        let fileReader = new FileReader();
        fileReader.onload = function () {

            let fileContent = event.target.result;
            $("#UserImg").attr("src", `${fileContent}`);
        };
        fileReader.readAsDataURL(firstFile);
    });
  
    //$(function () {
    //    $("#datepicker").datepicker();
    //});


    //$("#RegCancel").click(function () {
    //    $("#txtName").val("");
    //    $("#txtEmail").val("");
    //    $("#txtState").val("");
    //    $("#txtCountry").val("");
    //    $("#txtUsername").val("");
    //    $("#txtpassword").val("");
    //    $("#txtPhoneNo").val("");
    //    $("#UserImg").val("");
    //    $("#UserimgId").val("");
    //});


    //$("#TaskCancel").click(function () {
    //    $("#txtDescription").val("");
    //    $("#txtEmail").val("");
    //    $("#txtLocation").val("");
    //    $("#txtDate").val("");
    //    $("#txtUsername").val("");
    //    $("#txtPwd").val("");
       
    //});


    //$("#LogCancel").click(function () {
       
    //    $("#txtUsername").val("");
    //    $("#txtPwd").val("");
      
    //});
    



});