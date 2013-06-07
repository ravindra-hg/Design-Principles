Visitor Pattern:

Gang of Four definition:

Represent an operation to be performed on elements of an object structure. 
Visitor lets you define a new operation without changing the classes of the elements on which it operates.



Problem Statement: Think you are a Ticket booking agent for KSRTC Bus, VRL Bus,  Private busses.
					and already you have booked "N"  of orders in each system. so finally you are trying to get orders count.
					Solve this by using "VISITOR Pattern"
					
					but have technical constraint that each systems represents it's own order count object as follows
					~ KSRTC --> KSRTCOrders with "Count" property
					~ VRL --> VRLOrders with "TotalNumbers"
					~Private --> PrivateOrders with "TotalCount"
					
					 
