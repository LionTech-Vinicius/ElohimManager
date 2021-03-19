import React, { Component } from "react";
import { Link, Route } from "react-router-dom";
import routesConfig from "./routesconfig";
import "./App.css";
class App extends Component {
  render() {
    return (
      <div>
        <div className="App-header">
          <nav className="navbar navbar-expand-md navbar-dark fixed-top bg-dark">
            <div className="collapse navbar-collapse" id="navbarCollapse">
              <ul className="navbar-nav mr-auto">
                <li className="nav-item active">
                  <Link className="nav-link" to="/">
                    Home <span className="sr-only">(current)</span>
                  </Link>
                </li>
                <li className="nav-item">
                  <Link className="nav-link" to="/ministerios">
                    Ministério
                  </Link>
                </li>
                <li className="nav-item">
                  <Link className="nav-link" to="/projetos">
                    Projetos
                  </Link>
                </li>
                <li className="nav-item">
                  <Link className="nav-link" to="/agenda">
                    Agenda
                  </Link>
                </li>
                <li className="nav-item">
                  <Link className="nav-link" to="/contatos">
                    Contato
                  </Link>
                </li>
              </ul>
            </div>
          </nav>
        </div>

        <body className="App">
          {routesConfig.map((value, key) => {
            return (
              <Route
                key={key}
                path={value.path}
                component={value.component}
                exact={value.exact}
              ></Route>
            );
          })}
        </body>
        <footer>
          <nav className="navbar-expand-lg navbar-dark fixed-bottom bg-dark">
            <div className="collapse navbar-collapse App-footer">
              <span class="navbar-text">
                &copy; {new Date().getFullYear()} - Igreja Batista Provisão ||
                Copyright:{"   "}
                <a href="https://www.liontech.eti" target="blank">
                  {" "}
                  Lion Tech Consultoria e Desenvolvimento WEB{" "}
                </a>
              </span>
            </div>
          </nav>
        </footer>
      </div>
    );
  }
}
export default App;
