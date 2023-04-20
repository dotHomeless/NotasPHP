<?php

require_once 'mysqlConnections.php';

$results = array(
    array("IP_ADRESS", "COUNT(*)_", "Status", "IP_NAME")
);

$data_movimento = date("Y-m-d");

foreach ($mysqlConnections as $mysql) {
    $connection = new mysqli($mysql->Server, $mysql->Username, $mysql->Password, $mysql->Database);

    if ($connection->connect_error) {
        array_push($results, array($mysql->Server, 0, "Falha na conexao: " . $connection->connect_error, $mysql->IPName));
    } else {
        $query = "SELECT COUNT(*) FROM exp_imp_movimento WHERE data_movimento= ? AND numero_cupom <>0 AND codigo_operador<>0 AND situacao_movimento=1";
        $stmt = $connection->prepare($query);
        $stmt->bind_param("s", $data_movimento);
        $stmt->execute();
        $result = $stmt->get_result();
        $row = array($mysql->Server, $result->fetch_array()[0], "Conexao bem sucedida", $mysql->IPName);
        array_push($results, $row);
        $stmt->close();
    }
    $connection->close();
}

echo "<table>";
foreach ($results as $row) {
    echo "<tr>";
    foreach ($row as $cell) {
        echo "<td>" . $cell . "</td>";
    }
    echo "</tr>";
}
echo "</table>";
?>

//chame a função logo apos a um metodo
// No codigo está pegando a data do dia.
