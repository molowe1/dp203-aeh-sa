// Sample UDF which returns sum of two values.
function main(flowlog,index) {
    var Items = flowlog.split(',');
    return Items[index];
}