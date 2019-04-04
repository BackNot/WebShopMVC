$(document).ready()
{
   
    $('.a1').hide();
    $('.a2').hide();
    $('.a3').hide();
    $('.a4').hide();
    $('.a5').hide();
    $('.q1').click(function () {
        $('.list-group-item').removeClass("active");
        $(this).addClass("active");

        $('.a1').show();
        $('.a2').hide();
        $('.a3').hide();
        $('.a4').hide();
        $('.a5').hide();
    });

    $('.q2').click(function () {
        $('.list-group-item').removeClass("active");
        $(this).addClass("active");
        $('.a1').hide();
        $('.a2').show();
        $('.a3').hide();
        $('.a4').hide();
        $('.a5').hide();
    });
    $('.q3').click(function () {
        $('.list-group-item').removeClass("active");
        $(this).addClass("active");
        $('.a1').hide();
        $('.a2').hide();
        $('.a3').show();
        $('.a4').hide();
        $('.a5').hide();
    });
    $('.q4').click(function () {
        $('.list-group-item').removeClass("active");
        $(this).addClass("active");
        $('.a1').hide();
        $('.a2').hide();
        $('.a3').hide();
        $('.a4').show();
        $('.a5').hide();
    });
    $('.q5').click(function () {
        $('.list-group-item').removeClass("active");
        $(this).addClass("active");
        $('.a1').hide();
        $('.a2').hide();
        $('.a3').hide();
        $('.a4').hide();
        $('.a5').show();
    });
    $('.log-in-button').click(function () {
        $(location).attr('href', '/Home/Login')

    });
   
    $('.admin-panel-button').click(function () {
        $(location).attr('href', '/Admin/Index')

    });
    $('.create-button').click(function () {
        $(location).attr('href', '/Admin/Create')

    });
    $('.change-button').click(function () {
        $(location).attr('href', '/Admin/Edit')

    });
    $('.delete-button').click(function () {
        $(location).attr('href', '/Admin/Delete')

    });
    $('.purchases-button').click(function () {
        $(location).attr('href', '/AdminPurchases/Index')

    });
    $('.pending-button').click(function () {
        $('.status-color').addClass('text-warning');
        $('.status-color').removeClass('text-danger');
        $('.status-color').removeClass('text-success');

    });
    $('.delete-button').click(function () {
        $('.status-color').removeClass('text-warning');
        $('.status-color').addClass('text-danger');
        $('.status-color').removeClass('text-success');

    });
    $('.sent-button').click(function () {
        $('.status-color').removeClass('text-warning');
        $('.status-color').removeClass('text-danger');
        $('.status-color').addClass('text-success');

    });
 
 
    


}