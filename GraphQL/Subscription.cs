public class Subscribtion
{
    [Subscribe]
    public Book BookAdded([EventMessage] Book newBook) => newBook;

}