#Defining the hotel cost and calculating it
def hotel_cost():
    days = raw_input ("How many nights will you stay at the hotel? ")
    total = 70 * int(days) print "The total cost of the hotel is", total,

def plane_ticket():
    city = raw_input ("Which city are you traveling to? ")
    if city == 'New York':
        return "Cost = 2000"
    elif city == 'Auckland':
        return "Cost = 790"
    elif city == 'Venice'
        return "Cost = 154"
    elif city == 'Glasgow'
        return "Cost = 65"
    else:
        return "That isn't a valid city"

#Using the days the car is being used for from raw input, the different discounts are calculated and assigned to variables.
def rental_car_cost():
    rental_days = raw_input ("How many days will you rent the car? ")
    discount3 = 30
    discount7 = 50
    total_rent3 = 30 * int(rental_days) - discount3
    total_rent7 30 * int(rental_days) - discount7
    cost_day = 30 * int(rental_days)

    if int(rental_days) >= 3:
        print "The total cost of the car is", total_rent3
        return total_rent3
    elif int(rental_days) >= 7:
        print "The total cost of the car is", total_rent7
        return total_rent7
    else:
        print "The total cost of the car is", cost_day
        return cost_day

def trip_cost():
    travel_city = raw_input ("What city are you going to? ")
    days_travel = raw_input ("How many days will you be there? ")
    total_trip_cost = hotel_cost(int(days_travel)) + plane_ticket () + rental_car_cost(int(days_travel))
    return "The total cost of the trip is", total_trip_cost

trip_cost()
