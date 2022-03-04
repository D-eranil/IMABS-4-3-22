var pExpDays = 58;

var pCampaign = "J-AU-3089";
var pTargetURL2 = "";
var pTargetURL3 = SiteLink;
var ResellerStr = '',
    pTargetURL = findoutMoreLink;

function createCookie() {
    $.cookie('popupCK', pCampaign.toString(), {
        expires: pExpDays,
        path: '/'
    });
}

function Toogle_WCinput() {
    if ($('#wcpopupmode').is(":checked") == true) {
        $(".wcpopupclose").attr("id", "wcpopupclose-OFF");
    }
    else {
        $(".wcpopupclose").attr("id", "wcpopupclose");
    }

};

function closeModal() {
    if ($('#wcpopupmode').is(":checked") == true) {
        createCookie();
    }
    if (!$('#myModal').hasClass('hide')) {
        $('#myModal').addClass('hide');
    }

    if ($('#myModal').hasClass('show')) {
        $('#myModal').removeClass('show');
    }

    $('body').removeClass('modal-open');

    $('.modal-backdrop').remove();
    $("[id='myModal']").remove();
    
}

function redirectHome() {
    window.open(
        pTargetURL
    );
}

function redirect2() {
    window.open(
        pTargetURL2,
        '_blank'
    );
}

function redirect3() {
    window.open(
        pTargetURL3,
        '_blank'
    );
}
$(window).on("resize", function () {

    if ($('#myModal').hasClass('show')) {
        alignModal();
    }

});

function alignModal() {

    let modalDialog = $("#myModal").find(".modal-dialog");
    if ($(window).width() >= 768)
        modalDialog.css("margin-top", 100);
    else
        modalDialog.css("margin-top", Math.max(0, ($(window).height() - modalDialog.height()) / 2));

}

function display_camp() {
    if ($.cookie('popupCK') != pCampaign.toString()) {


        var htmlContent = $("<div/>").html(layoutReplaceHtml).text();
        
        $("body").append(htmlContent);

        $('#myModal').data('bs.modal', null); // this clears the BS modal data
        
        $('#myModal').modal({ backdrop: 'static', keyboard: false });


        if ($('#myModal').attr("style") !== typeof undefined && $('#myModal').attr("style") !== false) {
            $('#myModal').removeAttr("style")
        }

        if ($('#myModal').hasClass('hide')) {
            $('#myModal').removeClass('hide');
        }

        if (!$('#myModal').hasClass('show')) {
            $('#myModal').addClass('show');
        }

        $('#myModal').appendTo("body").modal('show');
        $('body').removeAttr('style');

        window.dataLayer = window.dataLayer || [];
        window.dataLayer.push({
            'event': 'WelcomePopup_Displayed',
            'value': pCampaign.toString()
        });
        createCookie();
    } else {

        if (!$('#myModal').hasClass('hide')) {
            $('#myModal').addClass('hide');
        }

        if ($('#myModal').hasClass('show')) {
            $('#myModal').removeClass('show');
        }

    }
}
$(document).ready(function () {
    
    display_camp();
    let popupwidth = $(window).width();
    let popupheight = $(window).height();

    let iconwidth = (popupwidth / 100) * 3;
    let iconheight = (popupwidth / 100) * 3;
    $('.wcpopup-icon-image').width(iconwidth).height(iconheight);

});