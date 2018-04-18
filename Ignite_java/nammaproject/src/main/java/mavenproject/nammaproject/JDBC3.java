package mavenproject.nammaproject;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.SQLException;
import java.sql.Statement;

import org.apache.ignite.Ignite;
import org.apache.ignite.Ignition;

public class JDBC3 
{
	public static void main(String[] args) throws ClassNotFoundException, SQLException 
	{
		Ignite ignite = Ignition.start();
		ignite.cluster().active(true);
		
		
		Class.forName("org.apache.ignite.IgniteJdbcThinDriver");
		Connection conn = DriverManager.getConnection("jdbc:ignite:thin://192.168.1.40/");
		try (Statement stmt = conn.createStatement()) 
		{
		    stmt.executeUpdate("CREATE TABLE EmployeeCreated (" + 
		    " id LONG PRIMARY KEY, name VARCHAR) " +
		    " WITH \"template=replicated\"");
		    
		    stmt.executeUpdate("CREATE TABLE PersonCreated (" +
		    " id LONG, name VARCHAR, city_id LONG, " +
		    " PRIMARY KEY (id, city_id)) " +
		    " WITH \"backups=1, affinityKey=city_id\"");
		    
		    stmt.executeUpdate("CREATE INDEX idx_employee_name ON EmployeeCreated (name)");
		    stmt.executeUpdate("CREATE INDEX idx_person_name ON PersonCreated (name)");
		}
		System.out.println("Tables created");
	}
}
