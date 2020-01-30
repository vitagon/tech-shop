import React, { Component } from 'react';
import { Table, Button } from 'react-bootstrap';
import { connect } from 'react-redux';
import {bindActionCreators} from 'redux';
import { fetchCategoriesAction, showDeleteCategoryModal } from '../../../actions/categoriesActions';
import { TOGGLE_EDIT_CATEGORY_COMP } from '../../../reducers/admin/categoriesReducer';

class CategoriesList extends Component {

  constructor(props) {
    super(props);
    console.log(process.env.REACT_APP_API_URL);
    this.showEditCategory = this.showEditCategory.bind(this);
  }

  // this is just an example that we can do so,
  // but I would prefer arrow function on onClick = {() => method()}
  showEditCategory(category) {
    return function () {
      this.props.showEditCategoryComp(category);
    }.bind(this);
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
            <Button variant="primary" size="sm" className="mr-2" onClick={this.showEditCategory(value)}>Edit</Button>
            <Button variant="danger" size="sm" onClick={() => this.props.showDeleteCategoryModal(value)}>Delete</Button>
          </td>
        </tr>
      )
    }

    return (
      <div>
        <Button variant="primary" onClick={this.props.fetchCategories} block className="mb-3">Get categories</Button>
        <Table striped bordered hover size="sm">
          <thead>
            <tr>
              <th>#</th>
              <th>Name</th>
              <th>Parent</th>
              <th style={{width: '130px'}}>Controls</th>
            </tr>
          </thead>
          <tbody>
            {categoriesEl}
          </tbody>
        </Table>
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
  fetchCategories: fetchCategoriesAction,
  showEditCategoryComp: (category) => {
    return (dispatch) => dispatch({
      type: TOGGLE_EDIT_CATEGORY_COMP,
      data: category,
      payload: false
    })
  },
  showDeleteCategoryModal: showDeleteCategoryModal
}, dispatch);

export default connect(mapStateToProps, mapDispatchToProps)(CategoriesList);