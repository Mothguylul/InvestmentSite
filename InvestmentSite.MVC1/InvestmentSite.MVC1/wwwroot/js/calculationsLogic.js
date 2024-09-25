class RowOfETFInvestement {
    constructor() {
        this.Id = null;  // id = month be cause one Month/Id is one Row 
        this.totalAmountOfCash = null;
        this.totalProfitMade = null;
        this.totalInterestMade = null;
    }
}

const startCapitalField = document.getElementById('loanamount');
const interestRateField = document.getElementById('interestrate');
const yearsField = document.getElementById('terminyears');
const tableBody = document.getElementById('tableBody');

// Generate the table by looping through the array of investment data
function generateTable(neededValues) {
    let html = "";
    tableBody.innerHTML = "";

    neededValues.forEach((investment) => {
        let row = `<tr>
                <td>${investment.Id}</td>
                <td>${formatAsCurrency(investment.totalAmountOfCash)}</td>
                <td>${formatAsCurrency(investment.totalProfitMade)}</td>
                <td>${investment.totalInterestMade.toFixed(2)}%</td>
              </tr>`;
        html += row;
    });

    tableBody.innerHTML = html;
}

// Function to calculate and return an array of investments for each month
function GiveValues() {
    console.log("givevalues()");

    // Get needed values
    let months = parseInt(yearsField.value) * 12;
    let startCapital = parseFloat(startCapitalField.value);
    let interestRate = parseFloat(interestRateField.value);

    // Calculate values
    let calculatedMonthlyInterestRate = Math.pow(1 + interestRate / 100, 1 / 12) - 1;
    let investmentsArray = [];

    for (let month = 1; month <= months; month++) {
        let investment = new RowOfETFInvestement();
        let totalAmountOfCash = startCapital * Math.pow(1 + calculatedMonthlyInterestRate, month);
        let totalProfitMade = totalAmountOfCash - startCapital;
        let totalInterestMade = (totalAmountOfCash / startCapital - 1) * 100;

        // pass values
        investment.Id = month;
        investment.totalAmountOfCash = totalAmountOfCash;
        investment.totalProfitMade = totalProfitMade;
        investment.totalInterestMade = totalInterestMade;

        // add to array
        investmentsArray.push(investment);
    }

    generateTable(investmentsArray);
}

// helper function copied from my pookie bear Jeremy ^^
function formatAsCurrency(number) {
    return "$" + number.toFixed(2).toString().replace(/\B(?=(\d{3})+(?!\d))/g, ",");
}

document.addEventListener("DOMContentLoaded", () => {
    console.log("DOM fully loaded");
    const calculationButton = document.getElementById('calculationbttn');
    calculationButton.addEventListener("click", () => {
        GiveValues();
    });
});


