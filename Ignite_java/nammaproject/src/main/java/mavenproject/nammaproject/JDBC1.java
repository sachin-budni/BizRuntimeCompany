package mavenproject.nammaproject;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.SQLException;
import java.sql.Statement;

import org.apache.ignite.Ignite;
import org.apache.ignite.Ignition;


public class JDBC1 
{
	public static void main(String[] args) throws Exception,ClassNotFoundException
	{
		Ignite ignite = Ignition.start();
		ignite.cluster().active(true);
		
		Class.forName("org.apache.ignite.IgniteJdbcThinDriver");
		Connection conn = DriverManager.getConnection("jdbc:ignite:thin://192.168.1.40/");
		
		try (Statement stmt = conn.createStatement()) 
		{
			stmt.executeUpdate("CREATE TABLE City1 (" + 
			" id LONG PRIMARY KEY, name VARCHAR) " +
			" WITH \"template=replicated\"");
			
			stmt.executeUpdate("CREATE TABLE Person11 (" +
			" id LONG, name VARCHAR, city_id LONG, " +
			" PRIMARY KEY (id, city_id)) " +
			" WITH \"backups=1, affinityKey=city_id\"");
			
			stmt.executeUpdate("CREATE INDEX idx_city_name ON City1 (name)");
			stmt.executeUpdate("CREATE INDEX idx_person_name ON Person11 (name)");
		}
		catch(SQLException ex)
		{
			ex.printStackTrace();
		}
		System.out.println("Tables created");
	}
}
