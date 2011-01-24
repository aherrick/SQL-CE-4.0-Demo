$(function () {


});

function deleteComment(id) {

    if (confirm('Are you sure you want to delete this Comment?')) {

        var parms = {
            id: id
        };

        $.ajax({
            type: "POST",
            url: "/Home/JSONDeleteComment",
            data: parms,
            dataType: "json",
            success: function (data) {

                location.reload();
            }
        });
    }

    return false;
}