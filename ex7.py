#I used float input to allow me to calculate using the
annual_salary = float(input("Type annual salary here : "))
portion_saved = float(input("Type the portion you want to save (as a decimal)      : "))
total_cost = float(input("Type the cost of your dream house here : "))
monthly_salary = (annual_salary / 12.0)

portion_down_payment = 0.25 * total_cost

current_savings = 0

returns = (current_savings * 0.4) / 12

overall_savings = returns + (portion_saved * monthly_salary)

months = 0

while current_savings < portion_down_payment:
    current_savings += current_savings * (0.4/12)
    current_savings += portion_saved
    months += 1
print("It will take {} months to sove!".format(months))
