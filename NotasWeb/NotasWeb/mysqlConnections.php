<?php
// mysql_connections.php

class MySQL_Connection {
    public $Server;
    public $IP;
    public $Database;
    public $Username;
    public $Password;
    public $IPName;

    public function __construct($server, $database, $username, $password, $ipName) {
        $this->Server = $server;
        $this->IP = $ip;
        $this->Database = $database;
        $this->Username = $username;
        $this->Password = $password;
        $this->IPName = $ipName;
    }

    public function ConnectionString() {
        return "Server=" . $this->Server . ";Database=" . $this->Database . ";Uid=" . $this->Username . ";Pwd=" . $this->Password . ";";
    }
}

$mysqlConnections = array(
    new MySQL_Connection("192.168.100.230", "concentrador", "leitura", "leitura123" ,"MATRIZ" ),
new MySQL_Connection("192.168.20.253", "concentrador", "econect", "123456" ,"0 - PAV 10" ),
new MySQL_Connection("192.168.20.243", "concentrador", "econect", "123456" ,"2 -  PAV 05" ),
new MySQL_Connection("192.168.1.243", "concentrador", "econect", "123456" ,"4 - DULCE" ),
new MySQL_Connection("192.168.7.243", "concentrador", "econect", "123456" ,"9 - COF" ),
new MySQL_Connection("192.168.4.243", "concentrador", "econect", "123456" ,"10 - TITO" ),
new MySQL_Connection("192.168.5.243", "concentrador", "econect", "123456" ,"11 - JF" ),
new MySQL_Connection("192.168.6.243", "concentrador", "econect", "123456" ,"12 - CEANORTE" ),
new MySQL_Connection("192.168.8.243", "concentrador", "econect", "123456" ,"14 - VAZ" ),
new MySQL_Connection("192.168.27.243", "concentrador", "econect", "123456" ,"15 - SION" ),
new MySQL_Connection("192.168.9.243", "concentrador", "econect", "123456" ,"18 - BRIGADEIRO" ),
new MySQL_Connection("192.168.11.243", "concentrador", "econect", "123456" ,"19 - DIV" ),
new MySQL_Connection("192.168.10.243", "concentrador", "econect", "123456" ,"20 - JUST" ),
new MySQL_Connection("192.168.12.243", "concentrador", "econect", "123456" ,"21 - PII" ),
new MySQL_Connection("192.168.13.243", "concentrador", "econect", "123456" ,"22 - JJ" ),
new MySQL_Connection("192.168.14.243", "concentrador", "econect", "123456" ,"23 - TROPICAL" ),
new MySQL_Connection("192.168.15.243", "concentrador", "econect", "123456" ,"24 - JARAGUA" ),
new MySQL_Connection("192.168.18.243", "concentrador", "econect", "123456" ,"26 - SERRANO" ),
new MySQL_Connection("192.168.16.243", "concentrador", "econect", "123456" ,"27 - HM" ),
new MySQL_Connection("192.168.17.243", "concentrador", "econect", "123456" ,"28 - BR040" ),
new MySQL_Connection("192.168.4.253", "concentrador", "econect", "123456" ,"29 - DC TITO" ),
new MySQL_Connection("192.168.12.253", "concentrador", "econect", "123456" ,"31 - DESTINO PII" ),
new MySQL_Connection("192.168.9.253", "concentrador", "econect", "123456" ,"32 - BRIGADEIRO" ),
new MySQL_Connection("192.168.1.242", "concentrador", "econect", "123456" ,"33 - DC DULCE" ),
new MySQL_Connection("192.168.19.243", "concentrador", "econect", "123456" ,"34 - ST LUZIA" ),
new MySQL_Connection("192.168.24.243", "concentrador", "econect", "123456" ,"35 - MANGABEIRA" ),
new MySQL_Connection("192.168.23.243", "concentrador", "econect", "123456" ,"36 - ITABIRA" ),
new MySQL_Connection("192.168.28.243", "concentrador", "econect", "123456" ,"37 - AMV" ),
new MySQL_Connection("192.168.22.243", "concentrador", "econect", "123456" ,"38 - JATAI" ),
new MySQL_Connection("192.168.25.243", "concentrador", "econect", "123456" ,"39 - IPATINGA" ),
new MySQL_Connection("192.168.30.243", "concentrador", "econect", "123456" ,"40 - SABARA" ),
new MySQL_Connection("192.168.26.243", "concentrador", "econect", "123456" ,"41 - BETANIA" ),
new MySQL_Connection("192.168.29.243", "concentrador", "econect", "123456" ,"42 - UBERABA" ),
new MySQL_Connection("192.168.44.243", "concentrador", "econect", "123456" ,"44 - JACUI" ),
new MySQL_Connection("192.168.12.242", "concentrador", "econect", "123456" ,"98 - BEBIDAS P2" )


);
