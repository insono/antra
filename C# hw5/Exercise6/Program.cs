Sqlconnection conn = new sqlconnection(MyConnectString);
Sqlcommand cmd = new sqlcommand(“sp_Myproc”, conn);
Conn.open();
cmd.ExecuteNonQuery();
And
Sqlconnection conn=new sqlconnection(Myconnectstring);
Sqlcommand cmd = new sqlcommand(“sp_Myproc”, conn);
Using(conn)
{
    Conn.open();
    cmd.ExecuteNonQuery();
}
