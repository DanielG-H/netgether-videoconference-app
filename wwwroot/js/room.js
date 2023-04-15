<script>
    var connection = new signalR.HubConnectionBuilder().withUrl("/chat").build();
    connection.start().catch(function (err) {
            return console.error(err.toString())
        });
</script>