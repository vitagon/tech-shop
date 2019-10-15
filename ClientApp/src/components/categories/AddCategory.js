import React, { Component } from "react";
import { connect } from 'react-redux';
import {bindActionCreators} from 'redux';
import {fetchCategoriesAction} from '../../actions/categoriesActions';
import { Formik, Form, Field, ErrorMessage } from 'formik';
import Axios from "axios";

class AddCategory extends Component {

  constructor(props) {
    super(props);
    this.state = {
    }
  }

  editCategory = () => {
    this.props.editCategory();
  }
  
  render() {
    let categoriesEl = [];

    for (const [index, value] of this.props.categories.entries()) {
      categoriesEl.push(
        <tr key={index}>
          <td>{value.id}</td>
          <td>{value.name}</td>
          <td>{value.parentId}</td>
          <td>
            <button type="button" className="btn btn-primary btn-sm mr-2">Edit</button>
            <button type="button" className="btn btn-danger btn-sm">Delete</button>
          </td>
        </tr>
      )
    }

    let {form} = this.state;

    return (
      <div>
        <h5>Add category</h5>
        <hr/>

        <Formik
          onSubmit={(values, actions) => {
            alert("Form is validated!");
            setTimeout( () => {
              actions.setSubmitting(false);
            }, 1000);
          }}
          initialValues={{
            name: '',
            parent: 23
          }}
          validate={values => {
            let errors = {};
            if (values.name === '') {
              errors.name = "*Name is required!";
            }
            
            return errors;
          }}
        >
          { ({touched, errors, isSubmitting }) => (
              <Form>
                <div className="form-group">
                  <label htmlFor="name">Name</label>
                  <Field
                    type="text"
                    name="name"
                    placeholder="Enter name"
                    className={`form-control ${touched.name && errors.name ? "is-invalid" : ""}`}
                  />
                  <ErrorMessage
                    component="div"
                    name="name"
                    className="invalid-feedback"
                  />
                </div>

                <div className="form-group">
                  <label htmlFor="parent">Parent</label>
                  <Field
                    component="select"
                    name="parent"
                    className={`form-control ${touched.parent && errors.parent ? "is-invalid" : ""}`}
                  >
                    <option value="0">No parent</option>
                    {this.props.categories.map(x => {
                      return <option value={x.id} key={x.id}>{x.name}</option>
                    })}
                  </Field>
                  <ErrorMessage
                    component="div"
                    name="parent"
                    className="invalid-feedback"
                  />
                </div>

                <button
                  type="submit"
                  className="btn btn-primary btn-block"
                  disabled={isSubmitting}
                >
                  {isSubmitting ? "Please wait..." : "Submit"}
                </button>
              </Form>
            )}
          </Formik>  
      </div>
    );
  }
};

const mapStateToProps = (state, ownProps) => {
  return {
    categories: state.categoriesReducer.categories
  }
}

const mapDispatchToProps = (dispatch) => bindActionCreators({
  fetchCategories: fetchCategoriesAction
}, dispatch);

export default connect(mapStateToProps, mapDispatchToProps)(AddCategory);