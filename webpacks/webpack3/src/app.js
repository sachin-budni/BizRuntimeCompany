import { bar, adding, substract } from "./bar";
import "./styles/styles.scss";

bar();
console.log(adding(22,34));
console.log(substract(32,12));

const arrowFunction=(a,b)=>a+ " "+ b;
console.log(arrowFunction(20,30));

const user = {
    id:1,
    name:"siva"
};
const advanceUser ={
    ...user,
    age:23
};
console.log(advanceUser);