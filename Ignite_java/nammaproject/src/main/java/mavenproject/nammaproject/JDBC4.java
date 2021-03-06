package mavenproject.nammaproject;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;

import org.apache.ignite.Ignite;
import org.apache.ignite.Ignition;

public class JDBC4 
{
	public static void main(String[] args) throws ClassNotFoundException, SQLException 
	{
		Ignite ignite = Ignition.start();
		ignite.cluster().active(true);
	
		
		
		Class.forName("org.apache.ignite.IgniteJdbcThinDriver");
		Connection conn = DriverManager.getConnection("jdbc:ignite:thin://192.168.1.40/");
		
		try (Statement stmt = conn.createStatement()) 
		{
		    try (ResultSet rs =//stmt.executeQuery("select * from EmployeeCreated"))
		    stmt.executeQuery("SELECT p.id, p.name, c.name " +
		    " FROM PersonCreated p, EmployeeCreated c " +
		    " WHERE p.city_id = c.id order by p.id"))    
		    {
		      while (rs.next())
		         System.out.println(rs.getString(1) + ", " + rs.getString(2)+","+rs.getString(3));
		    }
		}
	}
}
