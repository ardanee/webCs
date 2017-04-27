/*Ar: Helper para formularios y más*/

$(document).ready(function () {

   //Solo números a inputs con clase numeric
   $('.numeric').keypress(function (event) {
      return isNumber(event, this)
   }); //document ready


   //tab enter
   $(":input").bind("keydown", function (e) {
      if (e.keyCode == 13) {
         var allInputs = $("input,select,textarea,.btn");
         e.preventDefault();
         for (var i = 0; i < allInputs.length; i++) {
            if (allInputs[i] == this) {
               while ((allInputs[i]).name == (allInputs[i + 1]).name) {
                  i++;
               }

               if ((i + 1) < allInputs.length) $(allInputs[i + 1]).focus();
            }
         }
      }
   });
}); //end tab enter


function isNumber(evt, element) {
   /*restringe input para que solo acepte números 0-0 . -1 */
   var charCode = (evt.which) ? evt.which : event.keyCode

   //El guion solo puede estar al inicio
   console.log(charCode + '---' + $(element).val().length);
   if (charCode == 45 && $(element).val().length > 0) {
      return false;
   }

   //El punto no puede ser el primer elemento
   if (charCode == 46 && $(element).val().length == 0) {
      return false;
   }

   if (
            (charCode != 45 || $(element).val().indexOf('-') != -1) &&      // “-” CHECK MINUS, AND ONLY ONE.
            (charCode != 46 || $(element).val().indexOf('.') != -1) &&      // “.” CHECK DOT, AND ONLY ONE.
            (charCode < 48 || charCode > 57))
      return false;


   return true;
} // fin isNumber


function validarObligatorios() {
   var success = true;
   $('.obligatorio').each(function () {
      if ($(this).val() == "" || $(this).val() == "-1" || $(this).val() == "0" || $(this).val() == "0.00") {
         $(this).css("border-color", "#ff0000")
         if (success) {
            $(this).focus();
         }

         success = false;
      }
      else {
         $(this).css("border-color", "#1ddc21")
      }
   });
   if (!success) {
      alertify.error('Falta ingresar los datos obligatorios, verifique.');
      isValidate = false;
      $(".btn-success").delay(2000).removeClass('btn-loading');
   }
   return success;

}