
// this SC object should probably be encapsulated
// SC attributes shouldnt be public
SC.initialize({
    client_id: '8e847396c25e4e3ab45683caffa65506',
    redirect_uri: 'http://localhost:3000/callback.html'
});

function loginToSC(e) {
    e.preventDefault();
    SC.connect().then(function (data) {
        $("input[name='oauth']").val(data.oauth_token);
        document.forms[0].submit();
    });
}

function getFollowers() {
    var userID = $("#userID").val();
    $.ajax({
        url: "http://api.soundcloud.com/users/" + userID + "/followers?client_id=8e847396c25e4e3ab45683caffa65506",
        method: "GET",
        dataType: "json",
        success: function (data) {
            console.log(data);
        },
        error: function(jqXHR, textStatus, errorThrown) {
            console.log(errorThrown)
        }
    })
}

function getUsersYouFollow() {
    var userID = $("#userID").val();
    $.ajax({
        url: "http://api.soundcloud.com/users/" + userID + "/followings?client_id=8e847396c25e4e3ab45683caffa65506",
        method: "GET",
        dataType: "json",
        success: function (data) {
            console.log(data);
        },
        error: function (jqXHR, textStatus, errorThrown) {
            console.log(errorThrown)
        }
    })
}