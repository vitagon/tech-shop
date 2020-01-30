import React from 'react';
import { connect } from 'react-redux';
import { bindActionCreators } from 'redux';
import { getCategoriesTree } from '../../actions/categoriesTreeActions';
import { Link } from 'react-router-dom';
import { FontAwesomeIcon } from '@fortawesome/react-fontawesome';
import { faLaptop, faMobile } from '@fortawesome/free-solid-svg-icons';
import styles from './Categories.module.css';

class CategoryDetails extends React.Component {

  constructor(props) {
    super(props);
    this.props.getCategoriesTree();
    this.toUrl = this.toUrl.bind(this);
    console.log(this.props);
  }

  replaceAll(searchValue, replaceValue, str) {
    return str.split(searchValue).join(replaceValue);
  }

  toUrl(name) {
    name = name.toLowerCase();
    name = this.replaceAll(', ', '-', name);
    name = this.replaceAll(' ', '-', name);
    return name;
  }

  render() {
    if (this.props.categoriesTree.length > 0) {
      let root = this.props.categoriesTree[0];
      return (
        <div className="container">
          <h1 className="mb-5">Categories of products of "TechShop"</h1>

          {root.childrenList.map(x => {
            return (
              <div className="row mb-5 pb-5">
                <div className="col-md-12 mb-3">
                  <div className={styles['cat-header']}>
                    <div class={styles['img-wrap']}>
                      <FontAwesomeIcon icon={faLaptop} />
                    </div>
                    <Link to={() => this.toUrl(x.name)} className={styles['cat_link']}>{x.name}</Link>
                  </div>
                </div>

                {x.childrenList.map(y => {
                  return (
                    <div className="col-md-3">
                      <div className={styles['subcat-lvl2_wrap']}>
                        <div className="col-md-3 p-0">
                          <div className={styles['subcat-img-wrap']}>
                            <FontAwesomeIcon icon={faMobile} />
                          </div>
                        </div>

                        <div className="col-md-9 p-0">
                          <Link to={() => this.toUrl(y.name)} className={styles['subcat-lvl2_link']}>{y.name}</Link>

                          {y.childrenList && y.childrenList.map(z => {
                            return (
                              <div className={styles['subcat-lvl3']}>
                                <Link to={() => this.toUrl(z.name)} className={styles['subcat-lvl3_link']}>{z.name}</Link>
                              </div>
                            )
                          })}
                        </div>
                      </div>
                    </div>
                  )
                })}
              </div>
            )
          })}
        </div>
      );
    }
    return (<></>);
  }
}

const mapStateToProps = (state, ownProps) => ({
  categoriesTree: state.categoriesReducer.categoriesTree
});

const mapDispatchToProps = (dispatch) => bindActionCreators({
  getCategoriesTree: getCategoriesTree
}, dispatch);

export default connect(mapStateToProps, mapDispatchToProps)(CategoryDetails);