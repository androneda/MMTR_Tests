function validate() {
    var userName = document.getElementById("name");
    var timeOfDay = document.getElementsByName("daytime");
    var years = document.getElementById("age");
    var yearsTr = document.getElementById("yearsTr");

    if (!userName.value) {
        userName.style.border = "2px solid red";
        return false;
    }

    if (!years.checked) {
        yearsTr.style.border = "2px solid red";
        return false;
    }

    for (var i = 0; i < timeOfDay.length; i++) {
        if (timeOfDay[i].checked) {
            return true;
        }
    };
    // not checked, show error
    
    
}