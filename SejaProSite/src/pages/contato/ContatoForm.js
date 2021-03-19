import React from "react";
import { connect } from "react-redux";
import { reduxForm, Field } from "redux-form";
import { submitUserAction } from "../../actions/user/UserAction";

const ContatoFormFunc = (props) => {
  const { handleSubmit } = props;

  const submit = (data, submitUserAction) => {
    submitUserAction(data);
  };

  return (
    <form onSubmit={handleSubmit((fields) => submit(fields, submitUserAction))}>
      <div className="container">
        <div className="row">
          <label>Nome:</label>
          <Field
            type="text"
            component="input"
            name="name"
            className="form-control"
          />
        </div>
        <div className="row">
          <label>Email:</label>
          <Field
            type="text"
            component="input"
            name="email"
            className="form-control"
          />
        </div>
        <div className="row">
          <label>Mensagem:</label>
          <textarea
            rows="4"
            type="text"
            component="input"
            name="mensagem"
            className="form-control"
          />
        </div><br/>
        <div className="row">
          <button type="submit" className="btn btn-success">
            Enviar
          </button>
        </div>
      </div>
    </form>
  );
};

const ContatoForm = reduxForm({
  form: "formUser",
})(ContatoFormFunc);

const mapStateToProps = (state) => ({});

export default connect(mapStateToProps, { submitUserAction })(ContatoForm);
