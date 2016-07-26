<!DOCTYPE html>
<html>
<head>
<script>
 

function grabar( ) {
 
var producto = document.forms[0].producto.value;
var categoria = document.forms[0].categoria.value; 
var precio = document.forms[0].precio.value;

var Res = "Producto :" +producto +"- Categoria :" + categoria +"- Precio :" + precio;
document.forms[0].registroProducto.value = Res;

}

</script>
</head>
<body>
<form  >
                <fieldset>
                    <p>
                        <label for="producto">Nombre del producto:</label>
                        <input type="text" id="producto">
                    </p>
                    
                    <p>
                        <label for="Categoria">Nombre de la categoria:</label>
                        <input type="text" id="categoria">
                    </p>
                    
                    <p>
                        <label for="categoria">Precio s./:</label>
                        <input type="text" id="precio">
                    </p>
                     
                    <p>
                        <a id="registrar" onclick="grabar();">Registrar </a>
                    </p>
                </fieldset>
            
            <hr>
            <textarea id="registroProducto" cols="70" rows="15"></textarea>
            <hr>
            <button id="total_categorias">Categoria registradas </button>
            <button id="total_productos">Productos Registrados </button>
            <button id="suma_productos">La suma del precio de los productos </button>
            
			

        </form>


</body>
</html>