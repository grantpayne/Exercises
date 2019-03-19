//1.
function iqTest(str) {
    let nums = [];
    let odds = [];
    let evens = [];
    nums = str.split(' ');

    if (nums.length == 0) {
        return 0;
    }
    else {
        odds = nums.filter((element) => {
            return element % 2 == 1;
        });
        evens = nums.filter((element) => {
            return element % 2 == 0;
        });

        if (odds.length > evens.length &&
            evens.length == 1) {
                return nums.indexOf(evens[0]) + 1;
            }
        else if (evens.length > odds.length &&
            odds.length == 1) {
                return nums.indexOf(odds[0]) + 1;
            }
        else if (odds.length == 0 || evens.length == 0) {
            return 0;
        }
    }
    
}

//2.
function titleCase(str, ex) {
    str = str.toLowerCase();
    let phrase = [];
    phrase = str.split(' ');
    

    ex = ex.toLowerCase();
    let exeptions = [];
    exceptions = str.split(' ');


}