
$(document).ready(function(){

    $('#places-container').on('click','.remove',function(){
      var padre=$(this).parent().remove();
    });

});
