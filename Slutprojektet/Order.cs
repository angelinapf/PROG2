public class Order{
    // Attributes
    public int OrderNumber; // the number for the order, so the system can organize different orders
    public Customer Customer;
    public List<MenuItem> items; // a list of items that are eventually gonna be ordered and implemented into the order

    public Order(int orderNumber, Customer customer, List<MenuItem> items){
        OrderNumber = orderNumber; 
        Customer = customer;
    }


}