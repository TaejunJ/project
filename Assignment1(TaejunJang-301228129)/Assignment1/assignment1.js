
function bmr1() {
        var bmr;
        var calories = 0;

        var Name = document.getElementById("name").value;
        var Date = document.getElementById("date").value;
        var Age = document.getElementById("age").value;
        var Height = document.getElementById("height").value;
        var Weight = document.getElementById("weight").value;
        var men = document.getElementById("men").value;
        var women = document.getElementById("women").value;
        var activityLevel1 = document.getElementById("activityLevel1");
        var activityLevel2 = document.getElementById("activityLevel2");
        var activityLevel3 = document.getElementById("activityLevel3");
        var activityLevel4 = document.getElementById("activityLevel4");
        var activityLevel5 = document.getElementById("activityLevel5");
        (activityLevel1.checked) ? (calories += 1.2) : (calories += 0);
        (activityLevel2.checked) ? (calories += 1.375) : (calories += 0);
        (activityLevel3.checked) ? (calories += 1.55) : (calories += 0);
        (activityLevel4.checked) ? (calories += 1.725) : (calories += 0);
        (activityLevel5.checked) ? (calories += 1.9) : (calories += 0);
        (men.checked) ? bmr = 66.5 + (13.75 * Weight) + (5.003 * Height) - (6.755 * Age) : bmr = 655 + (9.563 * Weight) + (1.850 * Height) - (4.676 * Age);
        (women.checked) ? bmr = 655 + (9.563 * Weight) + (1.850 * Height) - (4.676 * Age) : bmr = 66.5 + (13.75 * Weight) + (5.003 * Height) - (6.755 * Age);
        var finalCalories = bmr + calories;
        document.write("<p>Here is your result!<p>")
        document.write("<p>Name: " + Name + ", Age: " + Age + "<p>")
        document.write(Date)
        document.write("<p>Your calculated BMR is (" + bmr + ").<p>")
        document.write("<p>Your calculated calories is (" + finalCalories + ").<p>")
}
function bmr2() {
    var bmr;
    var calories = 0;

    var Name = document.getElementById("name").value;
    var Date = document.getElementById("date").value;
    var Age = document.getElementById("age").value;
    var Height = document.getElementById("height").value;
    var Weight = document.getElementById("weight").value;
    var men = document.getElementById("men").value;
    var women = document.getElementById("women").value;
    var activityLevel1 = document.getElementById("activityLevel1");
    var activityLevel2 = document.getElementById("activityLevel2");
    var activityLevel3 = document.getElementById("activityLevel3");
    var activityLevel4 = document.getElementById("activityLevel4");
    var activityLevel5 = document.getElementById("activityLevel5");
    (activityLevel1.checked) ? (calories += 1.2) : (calories += 0);
    (activityLevel2.checked) ? (calories += 1.375) : (calories += 0);
    (activityLevel3.checked) ? (calories += 1.55) : (calories += 0);
    (activityLevel4.checked) ? (calories += 1.725) : (calories += 0);
    (activityLevel5.checked) ? (calories += 1.9) : (calories += 0);
    (men.checked) ? bmr = 66 + (6.2 * Weight) + (12.7 * Height) - (6.76 * Age) : bmr = 655 + (4.35 * Weight) + (4.7 * Height) - (4.7 * Age);
    (women.checked) ? bmr = 655 + (4.35 * Weight) + (4.7 * Height) - (4.7 * Age) : bmr = 66 + (6.2 * Weight) + (12.7 * Height) - (6.76 * Age);
    var finalCalories = bmr + calories;
    document.write("<p>Here is your result!<p>")
    document.write("<p>Name: " + Name + ", Age: " + Age + "<p>")
    document.write(Date)
    document.write("<p>Your calculated BMR is (" + bmr + ").<p>")
    document.write("<p>Your calculated calories is (" + finalCalories + ").<p>")
}
document.getElementById("submit-imperial")?.addEventListener("click", bmr2);
document.getElementById("submit-metric")?.addEventListener("click", bmr1);

