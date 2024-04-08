function LogFromFile() {
    alert('1');
    try {
        throw new Error("This is a test exception to log from jsnlogger file.");
    } catch (e) {
    }

    throw new Error("Sentry Test Error");

}


function LogFromFile2() {

    throw new Error("Sentry Test Error2");

}