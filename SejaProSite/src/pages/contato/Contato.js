import React, { Component } from "react";

import logoWhats from "../../images/logoWhats.png";
import logoFace from "../../images/logoFace.png";
import logoInsta from "../../images/logoInsta.png";
import logoYoutube from "../../images/logoYoutube.png";
import logoMail from "../../images/logoMail.svg";
import logoTele from "../../images/logoTele.png";
import ContatoForm from "./ContatoForm";

const width = 35;

class Contato extends Component {
  render() {
    return (
      <div className="container">
        <div className="row">
          <div className="col-md-6">
            <div className="container-fluid">
              <div className="row">
                <div className="col-md-6">
                  <h4>Nossos Contatos</h4>
                  <p>
                    <img src={logoTele} alt="logo Telefone" width={width} /> +55
                    (21) 2617 0884
                  </p>
                  <p>
                    <img src={logoTele} alt="logo Telefone" width={width} /> +55
                    (21) 99783-6160
                  </p>
                  <p>
                    <img src={logoWhats} alt="logo Whatsapp" width={width} />{" "}
                    (21) 99783-6160
                  </p>
                  <p>
                    <img src={logoMail} alt="logo Whatsapp" width={width} />{" "}
                    <a href="mailto:batistaprovisao@gmail.com" target="blank">
                      batistaprovisao@gmail.com
                    </a>
                  </p>
                  {/* <p>
                    <img src={logoMail} alt="logo Whatsapp" width={width} />{" "}
                    <a
                      href="mailto:pedidos@batistaprovisao.com.br"
                      target="blank"
                    >
                      pedidos@batistaprovisao.com.br
                    </a>
                  </p> */}
                </div>
                <div className="col-md-6">
                  <h4>Nossas Redes Sociais</h4>
                  <p>
                    <img src={logoFace} alt="logo Facebook" width={width} />{" "}
                    <a
                      href="https://www.facebook.com/batistaprovisaomp/"
                      target="blank"
                    >
                      @batistaprovisaomp
                    </a>
                  </p>
                  <p>
                    <img src={logoInsta} alt="logo Instagram" width={width} />{" "}
                    <a
                      href="https://www.instagram.com/batistaprovisaomp/"
                      target="blank"
                    >
                      @batistaprovisaomp
                    </a>
                  </p>
                  <p>
                    <img src={logoYoutube} alt="logo Youtube" width={width} />{" "}
                    <a
                      href="https://www.youtube.com/channel/UC-EKuvY6uV7sb5qjweYMPlg"
                      target="blank"
                    >
                      SEJA PRÓ
                    </a>
                  </p>
                </div>
              </div>
              <div className="row">
                <iframe
                  src="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3676.0139144587556!2d-43.02847878503486!3d-22.875944385027434!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x99855c7a761d57%3A0x40e68a7b90969f0e!2sIgreja%20Batista%20do%20Calv%C3%A1rio!5e0!3m2!1spt-BR!2sbr!4v1615675370210!5m2!1spt-BR!2sbr"
                  width="600"
                  height="270"
                  allowfullscreen=""
                  loading="lazy"
                  title="Visite-nos"
                ></iframe>
              </div>
            </div>
          </div>
          <div className="col-md-6">
            <h3>Envie-nos uma mensagem.</h3>
            <ContatoForm></ContatoForm>
          </div>
        </div>
      </div>
    );
  }
}

export default Contato;
