//1.
function sumDouble(x, y) {
    let sum = x + y;
    if (x == y) {
        sum *= 2;
    }
    return sum;
}

//2.
function hasTeen(x, y, z) {
    let result = false;
    if ((x >= 13 && x <= 19) ||
        (y >= 13 && y <= 19) ||
        (z >= 13 && z <= 19)) {
            result = true;
        }
    return result;
}

//3.
function lastDigit(x, y) {
    let result = false;
    if ((x - y) % 10 == 0) {
        result = true;
    }
    return result;
}

//4.
function seeColor(s) {
    let result = '';
    if (s.startsWith('red')) {
        result = 'red';
    }
    else if (s.startsWith('blue')) {
        result = 'blue';
    }
    return result;
}

//5.
function oddOnly(nums) {
    let result = [];
    for (let i = 0; i < nums.length; i++) {
        if (nums[i] % 2 == 1) {
            result.push(nums[i]);
        }
    }
    return result;
}

//6.
function frontAgain(str) {
    let result = false;
    if (str.length >= 2) {
        if (str.endsWith(str.substring(0, 2))) {
            result = true;
        }
    }
    return result;
}

//7.
function cigarParty(cigars, weekend) {
    let result = false;
    if ((cigars >= 40 && weekend) ||
        (cigars >= 40 && cigars <= 60)) {
            result = true;
        }
    return result;
}

//8.
function fizzBuzz(num) {
    result = num;
    if (num % 5 == 0 && num % 3 == 0) {
        result = 'FizzBuzz';
    }
    else if (num % 5 == 0) {
        result = 'Buzz';
    }
    else if (num % 3 == 0) {
        result = 'Fizz'
    }
    return result;
}

//9.
function filterEvens(nums) {
    let result = [];
    for (let i = 0; i < nums.length; i++) {
        if (nums[i] % 2 == 0) {
            result.push(nums[i]);
        }
    }
    return result;
}

//10.
function filterBigNumbers(nums) {
    let result = [];
    for (let i = 0; i < nums.length; i++) {
        if (nums[i] >= 100) {
            result.push(nums[i]);
        }
    }
    return result;
}

//11.
function filterMultiplesOfX(nums, x) {
    let result = [];
    for (let i = 0; i < nums.length; i++) {
        if (nums[i] % x == 0) {
            result.push(nums[i]);
        }
    }
    return result;
}

//12.
function createObject() {
    let object = {
        firstName: 'Grant',
        lastName: 'Payne',
        age: 29
    };
    return object;
}

