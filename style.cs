@charset "UTF-8";
* {
  margin: 0;
  padding: 0;
  box-sizing: border-box;
}

html {
  font-size: 14px;
  font-family: "Montserrat", sans-serif;
}

html {
  font-size: 14px;
  font-family: "Montserrat", sans-serif;
}

.header {
  padding: 0.5rem 0;
  position: sticky;
  top: 0rem;
  z-index: 1000;
  background-color: #4a707a;
  box-shadow: 0 5px 0.5rem rgba(94, 94, 94, 0.49);
  height: 100%;
}
@media only screen and (max-width: 575px) {
  .header {
    padding: 1rem 0 0 0;
  }
}
.header a {
  text-decoration: none;
  color: #DDDDDA;
}
.header .row {
  width: 100%;
}
@media only screen and (max-width: 991px) {
  .header .row {
    flex-direction: row-reverse;
    justify-content: center;
    align-items: flex-start;
  }
}

.header__menu {
  display: flex;
  justify-content: space-around;
  align-items: center;
  height: 100%;
}
@media only screen and (max-width: 991px) {
  .header__menu {
    justify-content: space-evenly;
  }
}
.header__menu img {
  width: 8rem;
}

.header__buscador, .header__buscadorMobile {
  width: 40%;
  height: 2rem;
  padding: 0.5rem;
  border: 1px solid #DDDDDA;
  border-radius: 1rem;
  outline: none;
  transition: all 0.3s ease;
  background: #94B0B7;
}
.header__buscador:hover, .header__buscadorMobile:hover, .header__buscador:focus, .header__buscadorMobile:focus {
  border: 1px solid #4a707a;
  background: #DDDDDA;
  box-shadow: 5px 5px 0 #94B0B7;
  transform: translate(0, -3px);
}

.header__buscadorMobile {
  width: 80%;
  height: 2rem;
}

.header__botonModal {
  border: none;
}
.header__botonModal:focus {
  box-shadow: none;
}

.header__botonSesion {
  width: 8.5rem;
  height: 2rem;
  display: flex;
  justify-content: center;
  align-items: center;
  border-radius: 1.5rem;
  transition: all 0.3s ease;
  background: #4a707a;
  box-shadow: -23 -23 45 #ffffff, 28 28 50 #0d27502f;
}
.header__botonSesion:hover {
  background: #DDDDDA;
  box-shadow: 5px 5px 0 #94B0B7;
  transform: translate(0, -3px);
}
.header__botonSesion:hover > input, .header__botonSesion:hover > ion-icon {
  color: #4a707a;
}
.header__botonSesion ion-icon {
  width: 1.5rem;
  height: 1.5rem;
  color: #DDDDDA;
}
.header__botonSesion input {
  border: none;
  outline: none;
  margin-left: 0.5rem;
  background: none;
  color: #DDDDDA;
}

.modal-backdrop {
  width: 100vw;
  height: 100vh;
  position: fixed;
  top: 0;
  left: 0;
  z-index: 200;
  background-color: #DDDDDA;
}

.header__modal .modal-dialog {
  width: 40%;
  height: 50%;
  position: relative;
  max-width: 100%;
  margin: 15rem auto;
  pointer-events: none;
}
@media only screen and (max-width: 991px) {
  .header__modal .modal-dialog {
    width: 50%;
    height: 30%;
    max-width: 50%;
  }
}
@media only screen and (max-width: 767px) {
  .header__modal .modal-dialog {
    width: 80%;
    height: 45%;
  }
}
@media only screen and (max-width: 575px) {
  .header__modal .modal-dialog {
    max-width: 80%;
  }
}
.header__modal .modal-dialog .modal-content {
  height: 100%;
  background: #4a707a;
}
.header__modal .modal-dialog .modal-content form {
  height: 100%;
  display: flex;
  flex-direction: column;
  justify-content: space-between;
  align-items: flex-start;
}
.header__modal .modal-dialog .modal-content form div {
  width: 100%;
  color: #DDDDDA;
}
.header__modal .modal-dialog .modal-content form h2 {
  font-size: 1.5rem;
  color: #DDDDDA;
}
.header__modal .modal-dialog .modal-content form div input {
  background: #4a707a;
  border: 1px solid #4a707a;
  color: #DDDDDA;
  border-radius: 0;
  padding: 0 0 0 0.2rem;
  height: 2.5rem;
  width: 100%;
  border-bottom: 1px solid #DDDDDA;
  transition: all 0.3s ease;
}
.header__modal .modal-dialog .modal-content form div input:hover, .header__modal .modal-dialog .modal-content form div input:focus {
  background: #DDDDDA;
  color: #4a707a;
  box-shadow: none;
  border: 1px solid #DDDDDA;
  border-radius: 0.2rem;
}
.header__modal .modal-dialog .modal-content form div input:hover::placeholder, .header__modal .modal-dialog .modal-content form div input:focus::placeholder {
  color: #4a707a;
}
.header__modal .modal-dialog .modal-content form div input::placeholder {
  color: #DDDDDA;
}
.header__modal .modal-dialog .modal-content form button {
  color: #DDDDDA;
  width: 50%;
  border: 1px solid #DDDDDA;
  border-radius: 1rem;
  transition: all 0.3s ease;
}
.header__modal .modal-dialog .modal-content form button:hover {
  border: 1px solid #DDDDDA;
  background: #DDDDDA;
  color: #4a707a;
}

.header__carrito {
  width: 2rem;
  height: 2rem;
  display: flex;
  justify-content: center;
  align-items: center;
  border-radius: 0.2rem;
  transition: all 0.3s ease;
}
.header__carrito a {
  color: #DDDDDA;
  transition: all 0.3s ease;
  display: flex;
  align-items: center;
}
.header__carrito:hover {
  background: #DDDDDA;
  border-radius: 0.2rem;
  box-shadow: 5px 5px 0 #94B0B7;
  transform: translate(0, -3px);
}
.header__carrito:hover a {
  color: #4a707a;
}
.header__carrito ion-icon {
  width: 1.8rem;
  height: 1.8rem;
}

.header__navbar {
  display: flex;
  align-items: center;
}
@media only screen and (max-width: 991px) {
  .header__navbar {
    position: relative;
    top: 0;
    margin-top: 1rem;
  }
}
.header__navbar .container-fluid {
  position: relative;
}

.header__toggler {
  width: 3rem;
  height: 100%;
}
@media only screen and (max-width: 991px) {
  .header__toggler {
    background: transparent;
  }
}
.header__toggler:focus {
  box-shadow: none;
}
.header__toggler ion-icon {
  width: 3rem;
  height: 3rem;
  color: #DDDDDA;
}

.header__collapse {
  display: flex;
  justify-content: center;
  padding-left: 0rem;
}
@media only screen and (max-width: 991px) {
  .header__collapse {
    justify-content: flex-start;
    margin-top: 1rem;
    background: #4a707a;
    position: absolute;
    top: 85%;
    width: 100vw;
  }
}

.header__ul {
  display: flex;
  justify-content: space-evenly;
  width: 90%;
}
@media only screen and (max-width: 991px) {
  .header__ul {
    width: 100%;
  }
  .header__ul div {
    padding-left: 1rem;
  }
}
.header__ul .active {
  font-weight: 700;
}
.header__ul .nav-item {
  height: 100%;
  padding: 0 0.8rem;
  list-style-type: none;
  position: relative;
  border: 1px solid transparent;
  border-radius: 1rem;
  transition: all 0.3s ease;
}
@media only screen and (max-width: 991px) {
  .header__ul .nav-item {
    border-bottom: none;
    margin: 0.5rem 0;
    padding-left: 1rem;
  }
}
.header__ul .nav-item:hover {
  box-shadow: 5px 5px 0 #94B0B7;
  transform: translate(0, -3px);
  border: 1px solid #94B0B7;
}
.header__ul .nav-item:focus {
  box-shadow: none;
  outline: none;
}
.header__ul .nav-item:nth-child(3):hover {
  box-shadow: 5px 5px 0 #94B0B7;
  transform: translate(0, -3px);
  border: 1px solid #94B0B7;
  border-bottom: 1px solid #4a707a;
}
@media only screen and (max-width: 991px) {
  .header__ul .nav-item:nth-child(3):hover {
    box-shadow: 0 0 0 #94B0B7;
    transform: translate(0, 0);
    border: none;
    border-bottom: 1px solid #4a707a;
  }
}
.header__ul .nav-link {
  font-size: 1.3rem;
  padding: 0;
  color: #DDDDDA;
}
.header__ul .nav-link .nav-link:hover {
  color: #DDDDDA;
}
.header__ul .nav-link .nav-link:focus {
  color: #DDDDDA;
}

.header__liCategoria {
  padding: 0;
  box-shadow: none;
  outline: none;
}
.header__liCategoria:hover > .header__submenu {
  transform: translate(0, 0);
  visibility: visible;
  opacity: 1;
}

.header__submenu {
  display: flex;
  position: absolute;
  margin-top: 0rem;
  top: 2rem;
  left: -10rem;
  border: 1px solid #94B0B7;
  background: #4a707a;
  border-radius: 0.2rem;
  overflow: hidden;
  z-index: 20;
  visibility: hidden;
  opacity: 0;
  transform: translate(0, 20%);
  transition: all 0.3s ease;
}
@media only screen and (max-width: 991px) {
  .header__submenu {
    display: none;
  }
}
.header__submenu li {
  display: flex;
  align-items: center;
  background: #DDDDDA;
  color: #4a707a;
  width: 15rem;
  height: 15rem;
  padding: 1rem 0.5rem;
  transition: all 0.3s ease;
}
.header__submenu li:first-child {
  padding: 1rem 0.5rem;
}
.header__submenu li:hover {
  background: #4a707a;
}
.header__submenu .header__imgCategoria {
  width: 100%;
  height: 85%;
  overflow: hidden;
}
.header__submenu .header__imgCategoria img {
  width: 100%;
  height: 100%;
  object-fit: cover;
  border-radius: 0.3rem;
}
.header__submenu li a {
  width: 100%;
  height: 100%;
  color: #4a707a;
  font-size: 1.3rem;
  transition: all 0.3s ease;
}
.header__submenu li:hover a {
  color: #DDDDDA;
}

@media only screen and (max-width: 991px) {
  .dropdown-menu {
    border: none;
    background: transparent;
  }
  .dropdown-menu li {
    display: flex;
    align-items: center;
    background: #4a707a;
    color: #DDDDDA;
    height: 2.2rem;
    margin-left: 0.5rem;
    border-left: 1px solid #DDDDDA;
    padding: 0 0.2rem;
    transition: all 0.3s ease;
  }
  .dropdown-menu li a {
    color: #DDDDDA;
    transition: all 0.3s ease;
  }
  .dropdown-menu li:hover {
    background: #DDDDDA;
  }
  .dropdown-menu li:hover a {
    box-shadow: 0 0 0 #94B0B7;
    transform: translate(5px, 0);
    color: #4a707a;
  }
}
html {
  font-size: 14px;
  font-family: "Montserrat", sans-serif;
}

.footer {
  height: 100%;
  padding: 2rem 0 2rem 0;
  background: #4a707a;
  display: flex;
  justify-content: space-evenly;
}

.footer__row {
  width: 100%;
  margin: 0;
}

.footer__menus {
  text-align: left;
  display: flex;
  flex-direction: column;
  justify-content: space-evenly;
}
@media only screen and (max-width: 767px) {
  .footer__menus {
    text-align: center;
    margin-bottom: 2rem;
  }
}
.footer__menus a {
  text-decoration: none;
  color: #DDDDDA;
  font-size: 1.2rem;
  border-radius: 1.5rem;
  padding: 0.3rem;
  margin: 0.2rem 0;
  transition: all 0.3s ease;
}
.footer__menus a:hover {
  background: #DDDDDA;
  color: #4a707a;
  box-shadow: 5px 5px 0 #94B0B7;
  transform: translate(0, -3px);
}
.footer__menus h5 {
  margin: 0;
}

.footer__datos {
  color: #DDDDDA;
  font-size: 1.1rem;
}
@media only screen and (max-width: 767px) {
  .footer__datos {
    margin-bottom: 2rem;
    text-align: center;
  }
}

.footer__enviosYPreguntas {
  display: flex;
  flex-direction: column;
  align-items: center;
}
@media only screen and (max-width: 575px) {
  .footer__enviosYPreguntas {
    margin-bottom: 2rem;
  }
}
.footer__enviosYPreguntas a {
  text-decoration: none;
  padding: 0 0.5rem;
  color: #DDDDDA;
  border: 1px solid #4a707a;
  border-radius: 1.5rem;
  transition: all 0.3s ease;
}
.footer__enviosYPreguntas a:hover {
  border: 1px solid #94B0B7;
  box-shadow: 5px 5px 0 #94B0B7;
  transform: translate(0, -3px);
}
.footer__enviosYPreguntas h5 {
  padding: 0.3rem;
  font-size: 1rem;
}

.footer__newsLetter {
  color: #DDDDDA;
  /* width: 15rem; */
}
@media only screen and (max-width: 575px) {
  .footer__newsLetter {
    margin-bottom: 2rem;
  }
}
.footer__newsLetter form {
  display: flex;
  flex-direction: column;
  align-items: center;
  justify-content: space-between;
}
.footer__newsLetter h5 {
  font-size: 1rem;
  letter-spacing: 1px;
}

.footer__inputMail {
  width: 15rem;
  height: 2rem;
  padding: 0.5rem;
  border: 1px solid #DDDDDA;
  color: #DDDDDA;
  border-radius: 1rem;
  outline: none;
  background: transparent;
  transition: all 0.3s ease;
}
.footer__inputMail::placeholder {
  text-align: center;
  color: #DDDDDA;
}
.footer__inputMail:hover, .footer__inputMail:focus {
  color: #4a707a;
  border: #DDDDDA;
  background: #DDDDDA;
  box-shadow: 5px 5px 0 #94B0B7;
  transform: translate(0, -3px);
}
.footer__inputMail:hover::placeholder, .footer__inputMail:focus::placeholder {
  color: #4a707a;
}

.footer__inputSub {
  width: 15rem;
  height: 2rem;
  z-index: 10;
  margin-top: 0.3rem;
  background: transparent;
  color: #DDDDDA;
  border: 1px solid #DDDDDA;
  border-radius: 1rem;
  font-size: 1.2rem;
  font-weight: 700;
  transition: all 0.3s ease;
}
.footer__inputSub:hover {
  color: #4a707a;
  background: #DDDDDA;
  box-shadow: 5px 5px 0 #94B0B7;
  transform: translate(0, -3px);
}

.footer__redes {
  display: flex;
  flex-direction: column;
  justify-content: space-evenly;
}
@media only screen and (max-width: 991px) {
  .footer__redes {
    flex-direction: row;
  }
}
.footer__redes div {
  display: flex;
  justify-content: center;
  align-items: center;
}
.footer__redes div ion-icon {
  width: 2rem;
  height: 2rem;
  color: #DDDDDA;
  transition: all 0.3s ease;
  border-radius: 0.5rem;
}
.footer__redes div a:hover ion-icon {
  box-shadow: 4px 4px 0 #94B0B7;
  transform: translate(0, -3px);
}

html {
  font-size: 14px;
  font-family: "Montserrat", sans-serif;
}

.indexMain {
  background: linear-gradient(to bottom, #94B0B7, #94b0b77c);
  padding-bottom: 2rem;
}

/*   CARRUSEL DE IMAGENES   */
.indexMain__carrusel {
  width: 100%;
  height: 50vh;
}
.indexMain__carrusel .indexMain__carruselContainer {
  width: 100%;
  height: 100%;
}

.carousel-inner {
  height: 100%;
}

.carousel-item {
  width: 100%;
  height: 100%;
  position: relative;
}
.carousel-item img {
  width: 100%;
  height: 100%;
  object-fit: cover;
  filter: brightness(70%);
}
.carousel-item__h3, .carousel-item__h4, .carousel-item__a {
  position: absolute;
  color: #DDDDDA;
  font-size: 3rem;
  top: 3rem;
  left: 10rem;
}
@media only screen and (max-width: 991px) {
  .carousel-item__h3, .carousel-item__h4, .carousel-item__a {
    font-size: 2.5rem;
    left: 8rem;
  }
}
@media only screen and (max-width: 767px) {
  .carousel-item__h3, .carousel-item__h4, .carousel-item__a {
    font-size: 2rem;
    left: 6rem;
  }
}
@media only screen and (max-width: 575px) {
  .carousel-item__h3, .carousel-item__h4, .carousel-item__a {
    font-size: 1.8rem;
    left: 2.5rem;
  }
}
.carousel-item__h4 {
  font-size: 1.3rem;
  top: 8rem;
}
@media only screen and (max-width: 575px) {
  .carousel-item__h4 {
    font-size: 0.8rem;
  }
}
.carousel-item__a {
  top: 11rem;
  text-decoration: 1px solid transparent;
  font-size: 3rem;
  font-weight: 700;
  transition: all 0.3s ease;
}
.carousel-item:hover > .carousel-item__a {
  color: #DDDDDA;
  transform: scale(1.1, 1.1);
  text-decoration: underline;
}

.carousel-control-next,
.carousel-control-prev {
  width: 11%;
}

/*   SECTION CATEGOR??AS   */
.indexMain__categorias {
  padding: 0 5rem;
  margin-top: 2rem;
}
@media only screen and (max-width: 575px) {
  .indexMain__categorias {
    padding: 0 2rem;
  }
}

.indexMain__categoriasTitulo {
  width: 100%;
  margin-bottom: 1rem;
  display: flex;
  justify-content: space-between;
}
@media only screen and (max-width: 575px) {
  .indexMain__categoriasTitulo {
    margin-bottom: 0;
  }
}
.indexMain__categoriasTitulo h2 {
  color: #4a707a;
}
@media only screen and (max-width: 575px) {
  .indexMain__categoriasTitulo h2 {
    font-size: 1.2rem;
  }
}
.indexMain__categoriasTitulo a {
  text-decoration: none;
}
@media only screen and (max-width: 575px) {
  .indexMain__categoriasTitulo a {
    text-align: right;
  }
}
.indexMain__categoriasTitulo h4 {
  color: #4a707a;
  border-bottom: transparent;
  transition: all 0.3s ease;
}
@media only screen and (max-width: 575px) {
  .indexMain__categoriasTitulo h4 {
    font-size: 0.9rem;
  }
}
.indexMain__categoriasTitulo a:hover > h4 {
  border-bottom: 1px solid #4a707a;
}

.indexMain__modalProducto:focus {
  box-shadow: none;
}

.producto {
  overflow: hidden;
  padding: 0.2rem;
  border-radius: 0.5rem;
  background: white;
  transition: all 0.3s ease;
}
.producto img {
  width: 100%;
  border-radius: 0.5rem;
  transition: all 0.3s ease;
}
.producto:hover {
  box-shadow: 4px 4px 10px #4a707a;
  transform: translate(0, -3px);
}
.producto--destacado, .producto--oferta {
  position: relative;
}

.modalProducto .modal-dialog {
  display: flex;
  justify-content: center;
  margin-top: 10%;
}
@media only screen and (max-width: 991px) {
  .modalProducto .modal-dialog {
    margin-top: 20%;
  }
}
@media only screen and (max-width: 767px) {
  .modalProducto .modal-dialog {
    margin-top: 20%;
  }
}
@media only screen and (max-width: 575px) {
  .modalProducto .modal-dialog {
    margin-top: 10%;
  }
}
.modalProducto .modal-content {
  width: 100%;
}
@media only screen and (max-width: 575px) {
  .modalProducto .modal-content {
    width: 75%;
  }
}
.modalProducto .modal-body {
  width: 100%;
}

.tarjetaModal {
  flex-direction: row;
  width: 100%;
}
@media only screen and (max-width: 575px) {
  .tarjetaModal {
    flex-direction: column;
  }
}
.tarjetaModal__img {
  width: 50%;
}
@media only screen and (max-width: 575px) {
  .tarjetaModal__img {
    width: 100%;
  }
}
.tarjetaModal__info {
  color: white;
  background: #94B0B7;
  display: flex;
  flex-direction: column;
  justify-content: space-between;
}
.tarjetaModal__nombre {
  font-size: 2rem;
}
.tarjetaModal__description {
  font-size: 1.2rem;
}
.tarjetaModal__boton {
  border-radius: 1.2rem;
  background: #4a707a;
  color: #DDDDDA;
  transition: all 0.3s ease;
}
.tarjetaModal__boton:hover {
  background: #DDDDDA;
  color: #4a707a;
}

.producto__numeroTop {
  width: 3rem;
  height: 2rem;
  position: absolute;
  right: 0.2rem;
  background-color: #DDDDDA;
  display: flex;
  justify-content: center;
  align-items: center;
  border-top-right-radius: 0.3rem;
  border-bottom-left-radius: 0.3rem;
  z-index: 110;
}
.producto__numeroTop span {
  font-weight: 700;
  color: #4a707a;
}

.producto__info {
  position: relative;
  z-index: 100;
  display: flex;
  padding: 0.5rem;
  justify-content: flex-start;
  flex-direction: column;
  align-items: flex-start;
  background: white;
  text-align: left;
}
.producto__info h5 {
  font-family: 100;
  font-size: 1.1rem;
}
.producto__info span {
  font-weight: 700;
  font-size: 1.3rem;
}
.producto__info span .badge {
  font-size: 1.4rem;
}

/*   SECTION DESTACADOS   */
.indexMain__destacados {
  /* grid-area: loMasVendido; */
  padding: 0 5rem;
}
@media only screen and (max-width: 575px) {
  .indexMain__destacados {
    padding: 0 2rem;
  }
}

.indexMain__destacadosTitulo {
  width: 100%;
  margin-bottom: 1rem;
  display: flex;
  justify-content: space-between;
}
@media only screen and (max-width: 575px) {
  .indexMain__destacadosTitulo {
    margin-bottom: 0;
  }
}
.indexMain__destacadosTitulo h2 {
  color: #4a707a;
}
@media only screen and (max-width: 575px) {
  .indexMain__destacadosTitulo h2 {
    font-size: 1.2rem;
  }
}
.indexMain__destacadosTitulo a {
  text-decoration: none;
}
@media only screen and (max-width: 575px) {
  .indexMain__destacadosTitulo a {
    text-align: right;
  }
}
.indexMain__destacadosTitulo h4 {
  color: #4a707a;
  border-bottom: transparent;
  transition: all 0.3s ease;
}
@media only screen and (max-width: 575px) {
  .indexMain__destacadosTitulo h4 {
    font-size: 0.9rem;
  }
}
.indexMain__destacadosTitulo a:hover > h4 {
  border-bottom: 1px solid #4a707a;
}

/*   SECTION OFERTAS   */
.indexMain__ofertas {
  padding: 0 5rem;
}
@media only screen and (max-width: 575px) {
  .indexMain__ofertas {
    padding: 0 2rem 2rem 2rem;
  }
}

.indexMain__ofertasTitulo {
  width: 100%;
  margin-bottom: 1rem;
  display: flex;
  justify-content: space-between;
}
@media only screen and (max-width: 575px) {
  .indexMain__ofertasTitulo {
    margin-bottom: 0;
  }
}
.indexMain__ofertasTitulo h2 {
  display: inline;
  color: #4a707a;
}
@media only screen and (max-width: 575px) {
  .indexMain__ofertasTitulo h2 {
    font-size: 1.2rem;
  }
}
.indexMain__ofertasTitulo a {
  text-decoration: none;
}
@media only screen and (max-width: 575px) {
  .indexMain__ofertasTitulo a {
    text-align: right;
  }
}
.indexMain__ofertasTitulo h4 {
  color: #4a707a;
  border-bottom: transparent;
  transition: all 0.3s ease;
}
@media only screen and (max-width: 575px) {
  .indexMain__ofertasTitulo h4 {
    font-size: 0.9rem;
  }
}
.indexMain__ofertasTitulo a:hover > h4 {
  border-bottom: 1px solid #4a707a;
}

.producto__info--oferta :nth-child(2) {
  text-decoration: line-through;
}

html {
  font-size: 14px;
  font-family: "Montserrat", sans-serif;
}

.indumentariaMain {
  height: 100%;
  background: linear-gradient(to bottom, #94B0B7, #DDDDDA);
}

.filtroResponsive__button {
  display: flex;
  justify-content: space-around;
  align-items: center;
  font-size: 1.5rem;
  border: 1px solid #DDDDDA;
  background: #94B0B7;
  width: 15%;
  margin: 0.5rem 0 0 auto;
}
.filtroResponsive__button:focus {
  box-shadow: none;
}
@media only screen and (max-width: 767px) {
  .filtroResponsive__button {
    width: 25%;
  }
}
@media only screen and (max-width: 575px) {
  .filtroResponsive__button {
    width: 50%;
  }
}

.filtroResponsive__container {
  background: #DDDDDA;
}
.filtroResponsive__container .offcanvas-header h5 {
  font-size: 2rem;
}

.filtro {
  height: 100%;
  padding: 0 1rem 0 0;
}
@media only screen and (max-width: 991px) {
  .filtro {
    padding: 0 4rem 0 0;
  }
}
@media only screen and (max-width: 767px) {
  .filtro {
    padding: 0 3rem 0 0;
  }
}
@media only screen and (max-width: 575px) {
  .filtro {
    padding: 0 2rem 0 0;
  }
}

.filtro__categorias,
.filtro__precios,
.filtro__loMasVendido {
  background: #DDDDDA;
  padding: 1rem;
}
@media only screen and (max-width: 991px) {
  .filtro__categorias,
.filtro__precios,
.filtro__loMasVendido {
    background: transparent;
  }
}

.filtro__categorias div, .filtro__precios div {
  margin: 1rem 0;
}
.filtro__categorias input, .filtro__precios input {
  width: 1rem;
  height: 1rem;
  margin: 0 0.5rem;
}
.filtro__categorias label, .filtro__precios label {
  font-size: 1rem;
  width: 90%;
  height: 2.5rem;
  background: #94B0B7;
  border-radius: 1.5rem;
  display: flex;
  align-items: center;
  transition: all 0.3s ease;
}
.filtro__categorias label:hover, .filtro__precios label:hover {
  box-shadow: -4px 4px 4px #4a707a;
  transform: translate(5px, 0);
}

.filtro__productos {
  width: 100%;
  height: 100%;
}

.miniProducto {
  width: 100%;
  height: 100%;
  margin-top: 1rem;
}
.miniProducto__aSelector {
  width: 100%;
  height: 7rem;
  display: flex;
  justify-content: space-between;
  align-items: center;
  text-decoration: none;
  color: #DDDDDA;
  background: #94B0B7;
  transition: all 0.3s ease;
  border-radius: 0.3rem;
  overflow: hidden;
  text-align: left;
}
.miniProducto__aSelector:hover {
  color: black;
  box-shadow: 2px 2px 4px #4a707a;
  transform: translate(0, -3px);
}
.miniProducto__imcContainer {
  width: 40%;
  height: 100%;
  display: flex;
}
.miniProducto__img {
  width: 100%;
  object-fit: fill;
  border-radius: 0.3rem;
}
.miniProducto__info {
  width: 50%;
  height: 100%;
  display: flex;
  flex-direction: column;
  justify-content: space-evenly;
  align-items: flex-start;
}
@media only screen and (max-width: 575px) {
  .miniProducto__info {
    font-size: 1rem;
  }
}
.miniProducto__info h5 {
  font-size: 1.3rem;
}
.miniProducto__info span {
  font-size: 1.5rem;
  font-weight: 700;
}

.indumentariaMain__productos {
  height: 100%;
}
.indumentariaMain__productos .row {
  height: 100%;
  padding-bottom: 1rem;
}

.miniProducto__button {
  width: 100%;
}

html {
  font-size: 14px;
  font-family: "Montserrat", sans-serif;
}

/*   MAIN   */
.loMasVendidoMain {
  padding: 2rem 4rem;
  background: linear-gradient(to bottom, #94B0B7, #DDDDDA);
}
@media only screen and (max-width: 767px) {
  .loMasVendidoMain {
    padding: 2rem 1rem;
  }
}

.loMasVendidoMain__modalProducto:focus {
  box-shadow: none;
}

html {
  font-size: 14px;
  font-family: "Montserrat", sans-serif;
}

/*   MAIN   */
.novedadesMain {
  width: 100%;
  height: 100%;
  background: url(images/bgNovedades.jpg);
  background-position: center;
  background-size: cover;
  background-repeat: no-repeat;
  display: flex;
  align-items: center;
}

.novedadesMain__contenedor {
  width: 100%;
  height: 100%;
  text-align: center;
  color: #4a707a;
  display: flex;
  justify-content: space-evenly;
  align-items: center;
  padding: 5rem 0;
}

.novedad {
  height: 20rem;
  display: flex;
  flex-direction: column;
  justify-content: space-around;
  align-items: center;
}
@media only screen and (max-width: 575px) {
  .novedad {
    height: 15rem;
  }
}
.novedad:hover {
  box-shadow: 5px 5px 5px #4a707a;
  transform: translate(0, -3px);
}
.novedad a {
  width: 80%;
  height: 2rem;
  margin-top: 5rem;
  display: flex;
  align-items: center;
  justify-content: center;
  text-decoration: none;
  border: 1px solid #4a707a;
  border-radius: 1rem;
  background: #DDDDDA;
  color: #4a707a;
  font-weight: 700;
  transition: all 0.3s ease;
}
@media only screen and (max-width: 575px) {
  .novedad a {
    width: 85%;
    height: 1.5rem;
    margin-top: 2rem;
  }
}
.novedad a:hover {
  background: #4a707a;
  color: #DDDDDA;
}
.novedad h3 {
  margin: 1rem 0;
  font-size: 1.3rem;
  color: #DDDDDA;
}
@media only screen and (max-width: 575px) {
  .novedad h3 {
    font-size: 1rem;
  }
}
.novedad h4 {
  font-size: 1.2rem;
  margin: 0;
}
@media only screen and (max-width: 575px) {
  .novedad h4 {
    font-size: 0.9rem;
  }
}

.novedad--novedad1 {
  background: url("../images/novedad1.jpg");
  background-position: center;
  background-size: 100%;
  background-repeat: no-repeat;
  transition: all 0.3s ease;
}

.novedad--novedad2 {
  background: url("../images/novedad2.jpg");
  background-position: center;
  background-size: 100%;
  background-repeat: no-repeat;
  transition: all 0.3s ease;
}

.novedad--novedad3 {
  background: url("../images/novedad3.jpg");
  background-position: center;
  background-size: 100%;
  background-repeat: no-repeat;
  transition: all 0.3s ease;
}

.novedad--novedad1 {
  background-position: bottom;
}

.novedad--novedad2 {
  background-size: cover;
}

html {
  font-size: 14px;
  font-family: "Montserrat", sans-serif;
}

/*   MAIN   */
.ofertasMain {
  padding: 2rem 4rem;
  background: linear-gradient(to bottom, #94B0B7, #DDDDDA);
}
@media only screen and (max-width: 767px) {
  .ofertasMain {
    padding: 2rem 1rem;
  }
}

.ofertasMain__modalProducto:focus {
  box-shadow: none;
}

html {
  font-size: 14px;
  font-family: "Montserrat", sans-serif;
}

.contactoMain {
  width: 100%;
  height: 100%;
  background: url(images/bgContacto.jpg);
  background-position: center;
  background-size: cover;
  background-repeat: no-repeat;
  filter: brightness(85%);
  display: flex;
  flex-direction: column;
  justify-content: center;
  align-items: center;
  padding: 2rem 0;
}

.contactoMain__contenedor {
  display: flex;
  flex-direction: column;
  justify-content: space-evenly;
  align-items: center;
  height: 100%;
  width: 100%;
}

.contactoMain__titulo {
  font-size: 2rem;
  color: #4a707a;
}

.form {
  padding: 2rem;
  display: flex;
  flex-direction: column;
  justify-content: space-around;
  background: #4a707a7c;
  border-radius: 0.3rem;
  height: 80%;
  width: 40%;
}
@media only screen and (max-width: 991px) {
  .form {
    width: 60%;
  }
}
@media only screen and (max-width: 767px) {
  .form {
    width: 80%;
  }
}

.form__Nombre,
.form__Apellido {
  background: none;
  border: none;
  width: 50%;
  border-bottom: 1px solid #4a707a;
  font-size: 1.5rem;
  outline: none;
  color: #DDDDDA;
}
.form__Nombre::placeholder,
.form__Apellido::placeholder {
  color: #DDDDDA;
}
@media only screen and (max-width: 575px) {
  .form__Nombre,
.form__Apellido {
    font-size: 1.2rem;
    width: 70%;
  }
}

.form__Email {
  display: flex;
  flex-direction: column;
  width: 100%;
  border: none;
  border-bottom: 1px solid #4a707a;
  background: none;
  font-size: 1.5rem;
  outline: none;
  margin-bottom: 1rem;
  color: #DDDDDA;
}
.form__Email::placeholder {
  color: #DDDDDA;
}
@media only screen and (max-width: 575px) {
  .form__Email {
    font-size: 1.2rem;
  }
}

.form__mensaje {
  width: 100%;
  resize: none;
  background: #4a707a;
  outline: none;
  padding: 0.5rem;
  margin-bottom: 1rem;
  color: #DDDDDA;
  font-size: 1.2rem;
  border: 1px solid #4a707a;
  transition: all 0.3s ease;
}
.form__mensaje:focus, .form__mensaje:hover {
  border: 1px solid #DDDDDA;
}
.form__mensaje::placeholder {
  font-size: 1.5rem;
  color: #DDDDDA;
}

.form__Buttons {
  display: flex;
  justify-content: space-around;
}
@media only screen and (max-width: 991px) {
  .form__Buttons {
    flex-direction: column;
    align-items: center;
    gap: 1rem;
  }
}

.form__submit,
.form__reset {
  border: 1px solid #4a707a;
  background: #4a707a;
  width: 45%;
  height: 2rem;
  border-radius: 1.5rem;
  font-size: 1.2rem;
  cursor: pointer;
  transition: all 0.3s ease;
  color: #DDDDDA;
}
.form__submit:hover, .form__submit:hover,
.form__reset:hover,
.form__reset:hover {
  border: 1px solid #4a707a;
  background: #DDDDDA;
  color: #4a707a;
}
@media only screen and (max-width: 991px) {
  .form__submit,
.form__reset {
    width: 70%;
  }
}

html {
  font-size: 14px;
  font-family: "Montserrat", sans-serif;
}

.error404 {
  background-color: #4a707a;
  width: 100vw;
  height: 100vh;
  display: flex;
  flex-direction: column;
  justify-content: flex-start;
  align-items: center;
}
.error404__a img {
  width: 10rem;
}
.error404__404 {
  font-size: 15rem;
}
.error404__info {
  font-size: 1.3rem;
  color: #DDDDDA;
}
.error404__home input {
  border: 1px solid #DDDDDA;
  color: #DDDDDA;
  background: transparent;
  border-radius: 1.5rem;
  padding: 0.5rem;
  transition: all 0.3s ease;
}
.error404__home input:hover {
  background: #DDDDDA;
  color: #4a707a;
}

/*# sourceMappingURL=style.cs.map */
