function activationKeys(arr) {
    arr = arr.filter(x => x !== "")
    let activationKey = arr.shift();
    arr.pop()
    arr = arr.map(x => x.split(">>>"));

    for (let i = 0; i < arr.length; i++) {
        let command = arr[i][0];
        switch (command) {
            case "Slice": {
                let firstIndex = Number(arr[i][1]);
                let lastIndex = Number(arr[i][2]);
                let elementsToRemove = lastIndex - firstIndex;
                activationKey = activationKey.split('');
                activationKey.splice(firstIndex, elementsToRemove);
                activationKey = activationKey.join('');
                console.log(activationKey);
            }
                break;
            case "Flip": {
                let firstIndex = Number(arr[i][2]);
                let lastIndex = Number(arr[i][3]);
                let substr = activationKey.slice(firstIndex, lastIndex);

                if (arr[i][1] == "Upper") {
                    substr = substr.toUpperCase();
                } else {
                    substr = substr.toLowerCase();
                }
                activationKey = activationKey.slice(0, firstIndex) + substr + activationKey.slice(lastIndex, activationKey.length);
            }
                console.log(activationKey)
                break;
            case "Contains": {
                if (activationKey.includes(arr[i][1])) {
                    console.log(`${activationKey} contains ${arr[i][1]}`);
                } else {
                    console.log("Substring not found!");
                }
            }
                break;
        }
    }
  
    return `Your activation key is: ${activationKey}`
}

console.log(activationKeys(["abcdefghijklmnopqrstuvwxyz",
    "Slice>>>2>>>6",
    "Flip>>>Upper>>>3>>>14",
    "Flip>>>Lower>>>5>>>7",
    "Contains>>>def",
    "Contains>>>deF",
    "Generate"
]
))
console.log(activationKeys(["134softsf5ftuni2020rockz42",
    "Slice>>>3>>>7",
    "Contains>>>-rock",
    "Contains>>>-uni-",
    "Contains>>>-rocks",
    "Flip>>>Upper>>>2>>>8",
    "Flip>>>Lower>>>5>>>11",
    "Generate"
    ]))