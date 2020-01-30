import React, { Component } from "react";
import { connect } from 'react-redux';
import { bindActionCreators } from 'redux';
import { createCategoryAction } from '../../../actions/categoriesActions';
import { Formik, Form, Field, ErrorMessage } from 'formik';
import { getCategoryByName } from '../../../services/CategoryService';
import * as Yup from 'yup';

const form = Yup.object().shape({
  name: Yup.string()
    .min(2, '*Name should have 2-50 symbols!')
    .max(50, '*Name should have 2-50 symbols!')
    .required('*Required')
});

class AddCategory extends Component {

  constructor(props) {
    super(props);
    this.state = {
    }
  }

  render() {
    return (
      <div className="mb-3">
        <h5>Add category</h5>
        <hr />

        <Formik
          onSubmit={async (values, actions) => {
            try {
              await getCategoryByName(values.name);
              actions.setErrors({
                name: '*Name already exists!'
              })
            } catch (e) {
            }
            actions.setSubmitting(false);
            this.props.createCategory(values);
          }}
          initialValues={{
            name: '',
            parent: 0
          }}
          validationSchema={form}
        >
          {({ touched, errors, isSubmitting }) => (
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
                {isSubmitting ? "Please wait..." : "Save"}
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
  createCategory: createCategoryAction
}, dispatch);

export default connect(mapStateToProps, mapDispatchToProps)(AddCategory);