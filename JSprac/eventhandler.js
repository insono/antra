function p1() {
    let salaries = {
        John: 100,
        Ann: 160,
        Pete: 130
    }
    var sum = salaries.John + salaries.Ann + salaries.Pete;
    console.log(sum);
}
p1();

let menu = {
    width: 200, height: 300, title: "My menu"
}

console.log(menu)
function multiplyNumeric(obj) {
    for (x in obj) {
        if (typeof obj[x] == 'number') {
            obj[x] *= 2;
        }
    }
}
multiplyNumeric(menu)
console.log(menu)

var email = "andrew@gmail.com"
function checkEmailID(email) {
    const re = /^(([^<>()[\]\\.,;:\s@"]+(\.[^<>()[\]\\.,;:\s@"]+)*)|(".+"))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$/;
    return re.test(String(email).toLowerCase());
}
console.log(checkEmailID(email))

var longStr = "What I'd like to tell on this topic is:"
function truncate(str, maxlength) {
    if (str.length > maxlength) {
        return str.substring(0, maxlength - 1) + "..."
    }
    return str
}
console.log(truncate(longStr, 20))

var arr1 = ["James", "Brennie"]
console.log(arr1)
arr1.push("Robert")
console.log(arr1)
arr1[(arr1.length - 1) / 2] = "Calvin"
console.log(arr1)
arr1.shift()
console.log(arr1)
arr1.unshift("Regal")
arr1.unshift("Rose")
console.log(arr1)

var card = "6724843711060148"
var banned = ["11", "3434", "67453", "9"]
function validateCard(x, bannedPrefixes) {
    var arr = []
    var isValid = false
    var isAllowed = true
    for (i = 0; i < x.length - 1; ++i) {
        arr.push(parseInt(x[i]))
    }
    for (i = 0; i < arr.length; ++i) {
        arr[i] *= 2;
    }
    var sum = 0;
    for (i = 0; i < arr.length; ++i) {
        sum += arr[i]
    }
    if (sum % 10 == x[x.length - 1]) {
        isValid = true
    }
    for (i = 0; i < bannedPrefixes.length; ++i) {
        if (x.startsWith(bannedPrefixes[i])) {
            isAllowed = false
        }
    }

    return [x, isValid, isAllowed]
}
console.log(validateCard(card, banned))

function validEmail(email) {
    const re = /^[a-z]{1,6}_?[0-9]{0,4}@hackerrank.com/;
    return re.test(String(email));
}

var emails = ["julia@hackerrank.com", "julia_@hackerrank.com", "julia_0@hackerrank.com", "julia0_@hackerrank.com", "julia@gmail.com"]
var emailResult = []
for (i = 0; i < emails.length; ++i) {
    emailResult.push(validEmail(emails[i]))
}
console.log(emails)
console.log(emailResult)