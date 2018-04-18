package mavenproject.nammaproject;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.SQLException;
import java.sql.Statement;

import org.apache.ignite.Ignite;
import org.apache.ignite.Ignition;

public class JDBC5 
{
	public static void main(String[] args) throws SQLException 
	{
		Ignite ignite = Ignition.start();
		ignite.cluster().active(true);
		
		Connection conn = DriverManager.getConnection("jdbc:ignite:thin://192.168.1.40/");
		try (Statement stmt = conn.createStatement()) 
		{
		    stmt.execute("drop table EmployeeCreated");	    
		}
		System.out.println("Drop the Table");
	}
}
